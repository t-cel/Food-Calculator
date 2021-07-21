using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace FoodCalculator
{
    public class MealsListViewHandler
    {
        public ListView listView { get; private set; }
        public MealInfo MealInfo { get; set; }

        //9
        private int[] sizeModifiers = new int[9];

        /// <summary>
        /// Initialize columns size dependency
        /// </summary>
        private void InitializeModifiers()
        {
            for (int i = 0; i < sizeModifiers.Length; i++)
            {
                sizeModifiers[i] = listView.Width / listView.Columns[i].Width;
            }
        }

        public void ResizeColumns()
        {
            for (int i = 0; i < sizeModifiers.Length; i++)
            {
                listView.Columns[i].Width = (int)((float)listView.Width * 0.92f / (float)sizeModifiers[i]);
            }
        }

        /// <summary>
        /// Remove item by ListViewItem
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItemFromList(ListViewItem item)
        {
            DialogResult result = MessageBox.Show("Do you really want to remove: " + item.Text + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mealListKey = GetMealKeyWithIndex(item.Index); //get key of pair that have selected item

                if (mealListKey != string.Empty) //if mealListKey is found
                {
                    /*
                    string s = "";
                    s += "serached index: " + item.Index + "\n";
                    s += "anaviable indexes: \n";
                    //MealInfo.Meals[mealListKey].Products.ForEach(product => s += product.Name + ", " + product.IndexInCalculator + "\n");

                    foreach(Product p in MealInfo.Meals[mealListKey].Products)
                    {
                        s += p.Name + ", " + p.IndexInCalculator + "\n";
                    }

                    MessageBox.Show(s);
                    */
                    var toRemove = MealInfo.Meals[mealListKey].Products.Find(product => product.IndexInCalculator == item.Index);
                    MealInfo.Meals[mealListKey].Products.Remove(toRemove); //remove selected item
                    SettingsManager.GetInstance.MakeAutosave();
                }
            }
        }

        /// <summary>
        /// Get meal that have item with specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetMealKeyWithIndex(int index)
        {
            foreach (KeyValuePair<string, Meal> pair in MealInfo.Meals)
            {
                if (index >= pair.Value.StartIndex && index <= pair.Value.EndIndex && pair.Value.StartIndex != -1)
                {
                    return pair.Key;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Refresh whole list
        /// </summary>
        public void RefreshList()
        {
            listView.Items.Clear();
            DrawList();
            listView.Focus();
        }

        /// <summary>
        /// Draw list with all meals
        /// </summary>
        public void DrawList()
        {
            int actualPosition = 0;
            var colorInfo = SettingsManager.GetInstance.settings;

            foreach (var meal in MealInfo.Meals) //all meals
            {
                var mealHeader = new ListViewItem(meal.Key.ToUpper());

                mealHeader.BackColor = colorInfo.MealColumnColor;
                mealHeader.ForeColor = colorInfo.MealTextColor;
                mealHeader.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);

                listView.Items.Add(mealHeader);
                actualPosition++; //header

                if (meal.Value.Products.Count == 0)
                {
                    meal.Value.StartIndex = meal.Value.EndIndex = -1;
                }
                else
                {
                    for (int i = 0; i < meal.Value.Products.Count; i++, actualPosition++)
                    {

                        if (i == 0)
                        {
                            meal.Value.StartIndex = actualPosition; //save start index (header!)
                            //MessageBox.Show("start index for meal: " + actualPosition);
                        }

                        if (i + 1 == meal.Value.Products.Count)
                        {
                            meal.Value.EndIndex = actualPosition; //save end index (last element!)
                            //MessageBox.Show("end index for meal: " + actualPosition);
                        }

                        Product p = meal.Value.Products[i];
                        p.IndexInCalculator = actualPosition; //save index in listview

                        //product properties
                        string[] product = {
                            p.Name,
                            p.Amount.ToString(),
                            p.Proteins.ToString(),
                            p.Fats.ToString(),
                            p.Carbo.ToString(),
                            p.Sugars.ToString(),
                            p.Fibers.ToString(),
                            p.Salts.ToString(),
                            p.Energy.ToString()
                        };

                        var productRow = new ListViewItem(product);

                        productRow.BackColor = colorInfo.ProductColumnColor;
                        productRow.ForeColor = colorInfo.ProductTextColor;

                        listView.Items.Add(productRow);
                        //MessageBox.Show(actualPosition + "");
                    }

                    if (meal.Value.Products.Count > 0)
                    {
                        //meal sum
                        actualPosition++;
                        List<string> mealSum = new List<string>();
                        mealSum.Add("SUM: "); 
                        mealSum.AddRange(meal.Value.GetSumOfAllProductsProperties().Select(sum => sum.ToString()));
                        var mealSumHeader = new ListViewItem(mealSum.ToArray());
                        mealSumHeader.BackColor = colorInfo.SumColumnColor;
                        mealSumHeader.ForeColor = colorInfo.SumColumnTextColor;
                        mealSumHeader.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
                        listView.Items.Add(mealSumHeader); //add to listview
                    }
                }
            }

            if (actualPosition > MealInfo.Meals.Count - 1) //if there are some items
            {
                actualPosition++;
                decimal[] sums = { //get all sums into array
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Amount)),
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Proteins)),
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Fats)),
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Carbo)),
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Sugars)),
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Fibers)),
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Salts)),
                    MealInfo.Meals.Sum(m => m.Value.Products.Sum(p => p.Energy)),
                 };

                //whole sum
                List<string> wholeSum = new List<string>();
                wholeSum.Add("TOTAL:");
                wholeSum.AddRange(sums.Select(sum => sum.ToString()));

                var wholeSumHeader = new ListViewItem(wholeSum.ToArray());
                wholeSumHeader.BackColor = colorInfo.WholeSumColumnColor;
                wholeSumHeader.ForeColor = colorInfo.WholeSumColumnTextColor;
                wholeSumHeader.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
                listView.Items.Add(wholeSumHeader); //add to listview
            }
        }

        public MealsListViewHandler(ListView listView, MealInfo mealInfo)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(5, 20);
            listView.SmallImageList = imgList;

            this.listView = listView;
            MealInfo = mealInfo;

            InitializeModifiers();
        }
    }
}
