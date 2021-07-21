using System;
using System.Windows.Forms;
using System.IO;

namespace FoodCalculator
{
    public partial class ProductField : Form
    {
        private Product product;
        private bool createNew = false;
        private int productIndex = 0;

        public ProductField(Product product = null, int productIndex = 0)
        {
            InitializeComponent();

            ControlsManager.SetColorsInForm(this);
            this.product = product;

            if (this.product != null)
            {
                button1.Text = "Save Changes";

                if (product.ImageName != string.Empty)
                {
                    pictureBox1.ImageLocation = "resources\\" + product.ImageName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

                RefreshFields();
            }
            else
            {
                button1.Text = "Add";
                this.product = new Product();
                createNew = true;
            }

            this.productIndex = productIndex;
            comboBox1.SelectedIndex = 0;
        }

        public void RefreshFields()
        {
            //load all properties from product to boxes.
            productName.Text = product.Name;
            measureBox.Value = product.Amount;
            energyBox.Value = product.Energy;
            proteinsBox.Value = product.Proteins;
            fatsBox.Value = product.Fats;
            carboBox.Value = product.Carbo;
            sugarsBox.Value = product.Sugars;
            fibersBox.Value = product.Fibers;
            saltsBox.Value = product.Salts;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool AllFieldsAreFilled()
        {
            if (productName.Text.Length == 0)
                return false;

            foreach (Control c in panel1.Controls)
            {
                var field = c as NumericUpDown;
                if (field != null && field.Text.Length == 0)
                    return false;
            }
            return true;
        }

        private void SetProduct()
        {
            //save all properties to
            product.Name = productName.Text;
            product.Amount = measureBox.Value;
            product.Energy = energyBox.Value;
            product.Proteins = proteinsBox.Value;
            product.Fats = fatsBox.Value;
            product.Carbo = carboBox.Value;
            product.Sugars = sugarsBox.Value;
            product.Fibers = fibersBox.Value;
            product.Salts = saltsBox.Value;

            //product.Measure = comboBox1.SelectedValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(!AllFieldsAreFilled())
            {
                MessageBox.Show("Fill in all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SetProduct();

            if (createNew)
            {
                DatabaseSerializer.Database.Foods.Add(product);
                productIndex = DatabaseSerializer.Database.Foods.Count - 1;
            }

            ProductsDatabase.Instance.RefreshWindow(true, productIndex);

            Close();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            //"txt files (*.txt)|*.txt|All files (*.*)|*.*" 
            dialog.RestoreDirectory = true;
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName != null)
                {
                    product.ImageName = dialog.SafeFileName; //save name

                    if(!Directory.Exists("resources"))
                    {
                        Directory.CreateDirectory("resources");
                    }

                    File.Copy(dialog.FileName, "resources\\" + dialog.SafeFileName, true);

                    pictureBox1.ImageLocation = "resources\\" + dialog.SafeFileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}
