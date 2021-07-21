using System.Windows.Forms;
using System.Linq;

namespace FoodCalculator
{
    public partial class ProductsDatabase : Form
    {
        public static ProductsDatabase Instance { get; private set; }

        public ProductsDatabase()
        {
            Instance = this;
            InitializeComponent();
            ControlsManager.SetColorsInForm(this);

            comboBox1.SelectedIndex = 0;
            RefreshWindow();
            AddItemsToList();
        }

        public void RefreshWindow(bool updateList = true, int indexToSelect = 0)
        {
            bool enable = false;

            if (updateList)
            {
                AddItemsToList();
            }

            if (productsList.Items.Count > 0)
            {
                enable = true;
                productsList.SelectedIndex = indexToSelect;
            }

            modifyButton.Enabled = enable;
            button5.Enabled = enable;
        }

        private void AddItemsToList(string startsWith = "")
        {
            productsList.Items.Clear(); //clear list

            if (startsWith != string.Empty)
            {
                /*
                string [] starts = DatabaseSerializer.Database.Foods.Select(food => food.Name).ToList().FindAll(str => str.ToLower().StartsWith(startsWith)).ToArray();

                if(starts.Length > 0)
                {
                    productsList.Items.Add(new ListViewItem(starts));
                }
                */
            }
            else
            {
                DatabaseSerializer.Database.Foods = DatabaseSerializer.Database.Foods.OrderBy(product => product.Name).ToList(); //sort alphabetically
                foreach (Product p in DatabaseSerializer.Database.Foods)
                    productsList.Items.Add(p.Name);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ProductField productField = new ProductField();
            productField.ShowDialog(this);
        }

       

        /// <summary>
        /// Remove product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, System.EventArgs e)
        {
            if (productsList.SelectedIndex != -1)
            {
                DatabaseSerializer.Database.Foods.RemoveAt(productsList.SelectedIndex);
                RefreshWindow();
            }
        }

        private void modifyButton_Click(object sender, System.EventArgs e)
        {
            if (productsList.SelectedIndex != -1)
            {
                ProductField productField = new ProductField(DatabaseSerializer.Database.Foods[productsList.SelectedIndex], productsList.SelectedIndex);
                productField.ShowDialog(this);
            }
        }

        private void productsList_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {
            if (productsList.SelectedIndex != -1)
            {
                Product product = DatabaseSerializer.Database.Foods[productsList.SelectedIndex];

                productName.Text = product.Name;

                measureBox.Text = product.Amount.ToString();
                energyBox.Text = product.Energy.ToString();
                proteinsBox.Text = product.Proteins.ToString();
                fatsBox.Text = product.Fats.ToString();
                carboBox.Text = product.Carbo.ToString();
                sugarsBox.Text = product.Sugars.ToString();
                fibersBox.Text = product.Fibers.ToString();
                saltsBox.Text = product.Salts.ToString();

                if (product.ImageName != string.Empty)
                {
                    pictureBox1.ImageLocation = "resources\\" + product.ImageName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}
