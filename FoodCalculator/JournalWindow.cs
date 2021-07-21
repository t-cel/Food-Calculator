using System;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class JournalWindow : Form
    {
        public MealsListViewHandler Handler { get; set; }
        private DayInfo actualDayProducts;

        public JournalWindow()
        {
            InitializeComponent();

            option1comboBox.SelectedIndex = 0;
            option2comboBox.SelectedIndex = 0;
            option3comboBox.SelectedIndex = 0;
            option4comboBox.SelectedIndex = 0;

            ControlsManager.SetColorsInForm(this);
            FindDayWithDate(DateTime.Today.Date);
        }

        private void FindDayWithDate(DateTime date)
        {
            actualDayProducts = DatabaseSerializer.CalendarProductsInfo.Find(day => day.date.Date == date) as DayInfo; //load today meals info
            if (actualDayProducts == null)
            {
                actualDayProducts = new DayInfo(date); //create new day, with today date
                DatabaseSerializer.CalendarProductsInfo.Add(actualDayProducts);
            }

            Handler = new MealsListViewHandler(productsListview, actualDayProducts.mealsInfo); //initialize handler

            Handler.RefreshList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FindDayWithDate(dateTimePicker1.Value.Date);
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow(actualDayProducts.mealsInfo, Handler);
            addProductWindow.Show(this);
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            if (productsListview.SelectedItems.Count > 0)
            {
                ListViewItem item = productsListview.SelectedItems[0];
                Handler.RemoveItemFromList(item);
                Handler.RefreshList(); //after all, refresh
                removeProduct.Enabled = false;
            }
        }

        private void productsListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsListview.SelectedItems.Count > 0)
            {
                ListViewItem item = productsListview.SelectedItems[0]; //get selected item
                bool invalidRow = Handler.GetMealKeyWithIndex(item.Index) == string.Empty; //is selected item valid product?
                removeProduct.Enabled = !invalidRow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseSerializer.Serialize(DatabaseSerializer.defaultPath);
        }

        private void moveData_Click(object sender, EventArgs e)
        {
            if(FoodCalculator.Instance == null)
            {
                new FoodCalculator().Show();
            }

            new DataOperationManager((DataOperationManager.MoveType)        option1comboBox.SelectedIndex,
                                                                            option2comboBox.SelectedIndex,
                                     (DataOperationManager.DataContext)     option3comboBox.SelectedIndex,
                                     (DataOperationManager.OperationEffect) option4comboBox.SelectedIndex)
                                     .ExecuteOperation(DatabaseSerializer.CalculatorMealInfo, actualDayProducts.mealsInfo);
            Handler.RefreshList();
        }

        private void JournalWindow_Resize(object sender, EventArgs e)
        {
            Handler.ResizeColumns();
        }
    }

    /// <summary>
    /// Describes data operations
    /// </summary>
    public class DataOperationManager
    {
        #region enums

        public enum MoveType
        {
            Move, Copy
        }

        public enum DataContext
        {
            FromCalculatorToJournal, FromJournalToCalculator
        }

        public enum OperationEffect
        {
            ReplaceExisting, AddToExisting
        }

        #endregion enums

        private MoveType        moveType;
        private int             contentIndex;
        private DataContext     context;
        private OperationEffect effect;

        private MealInfo sourceMeal, destMeal;

        public void ExecuteOperation(MealInfo calculator, MealInfo journal)
        {
            sourceMeal = context == DataContext.FromCalculatorToJournal ? calculator : journal;
            destMeal = context == DataContext.FromCalculatorToJournal ? journal : calculator;

            if (contentIndex != 0) //operation for specified meal
            {
                var mealName = MealInfo.mealNames[contentIndex - 1];
                if (effect == OperationEffect.ReplaceExisting) //remove dest meal
                {
                    destMeal.Meals[mealName].Products.Clear();
                    destMeal.Meals[mealName].Products.AddRange(sourceMeal.Meals[mealName].Products); //replace 
                }
                else
                {
                    destMeal.Meals[mealName].Products.AddRange(sourceMeal.Meals[mealName].Products); //add source meal products to destination meal products
                }

                if (moveType == MoveType.Move) //clear source products for specified meal
                {
                    sourceMeal.Meals[mealName].Products.Clear();
                }
            }
            else //operation for all meals
            {
                if (effect == OperationEffect.ReplaceExisting)
                {
                    foreach (var keyPair in sourceMeal.Meals)
                    {
                        destMeal.Meals[keyPair.Key].Products.Clear();
                        destMeal.Meals[keyPair.Key].Products.AddRange(keyPair.Value.Products); //replace products
                    }
                }
                else
                {
                    foreach (var keyPair in sourceMeal.Meals)
                    {
                        destMeal.Meals[keyPair.Key].Products.AddRange(keyPair.Value.Products); //add all products
                    }
                }

                if (moveType == MoveType.Move) //clear source products for all meals
                {
                    foreach (var keyPair in sourceMeal.Meals)
                    {
                        keyPair.Value.Products.Clear();
                    }
                }
            }

            if(FoodCalculator.Instance != null)
            {
                FoodCalculator.Instance.Handler.RefreshList();
            }

            SettingsManager.GetInstance.MakeAutosave();
        }

        public DataOperationManager(MoveType moveType, int contentIndex, DataContext context, OperationEffect effect)
        {
            this.moveType = moveType;
            this.contentIndex = contentIndex;
            this.context = context;
            this.effect = effect;
        }
    }
}
