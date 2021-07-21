using System;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class AddProductWindow : Form
    {
        public MealInfo actualMealInfo { get; set; }
        public MealsListViewHandler Handler { get; private set; }

        public AddProductWindow(MealInfo actualMealInfo, MealsListViewHandler handler)
        {
            InitializeComponent();

            this.actualMealInfo = actualMealInfo;
            Handler = handler;

            foreach(var meal in actualMealInfo.Meals)
            {
                mealsCombobox.Items.Add(meal.Key);
            }

            if(mealsCombobox.Items.Count > 0)
                mealsCombobox.SelectedIndex = 0;
            
            foreach(Product p in DatabaseSerializer.Database.Foods)
            {
                productsListBox.Items.Add(p.Name);
            }   
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedIndex != -1)
            {
                string mealName = mealsCombobox.SelectedItem.ToString();

                Product p = new Product();
                p = (Product)DatabaseSerializer.Database.Foods[productsListBox.SelectedIndex].Clone(); //make memberwise copy :)

                actualMealInfo.Meals[mealName].Products.Add(p); //add new product to specified list

                Handler.RefreshList(); //refresh listview
                SettingsManager.GetInstance.MakeAutosave();
                Close();
            }
            else
                MessageBox.Show("Select the product you wish to add to the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
