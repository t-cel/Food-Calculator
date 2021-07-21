using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class FoodCalculator : Form
    {
        public static FoodCalculator Instance { get; private set; }

        public MealsListViewHandler Handler { get; set; }
        

        public FoodCalculator()
        {
            InitializeComponent();

            //actualMealInfo = new MealInfo();
            Handler = new MealsListViewHandler(listView1, DatabaseSerializer.CalculatorMealInfo); //init handler
            ControlsManager.SetColorsInForm(this);

            Instance = this;

            //Test();
            Handler.RefreshList();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow(DatabaseSerializer.CalculatorMealInfo, Handler);
            addProductWindow.Show(this);
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                Handler.RemoveItemFromList(item);
                Handler.RefreshList(); //after all, refresh
                removeProduct.Enabled = false;
            }
        }


        /// <summary>
        /// Changing selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0]; //get selected item
                bool invalidRow = Handler.GetMealKeyWithIndex(item.Index) == string.Empty; //is selected item valid product?
                removeProduct.Enabled = !invalidRow;
            }
        }

        private void saveListPicture_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save("zdj.png", ImageFormat.Jpeg);
        }

        private void FoodCalculator_Resize(object sender, EventArgs e)
        {
            Handler.ResizeColumns();
        }
    }
}