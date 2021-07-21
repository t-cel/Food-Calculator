using System;
using System.Windows.Forms;
using System.Linq;

namespace FoodCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            DatabaseSerializer.Deserialize(DatabaseSerializer.defaultPath);
            SettingsManager.GetInstance.LoadSettings();

            ControlsManager.SetColorsInForm(this);
        }

        /// <summary>
        /// Check that only one window with specified type is open
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void OpenWindow<T>() where T : Form, new()
        {
            if (Application.OpenForms.OfType<T>().Count() == 0)
            {
                new T().Show();
            }
            else
            {
                MessageBox.Show("One window of this type is already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Refreshs windows that manages database items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private static void RefreshWindows<T>() where T : Form, new()
        {
            var openTForms = Application.OpenForms.OfType<T>();

            //refresh windows
            if (openTForms.Count() > 0)
            {
                var form = openTForms.ElementAt(0); //only one form with specified type can be opened
                var lastPosition = form.Location; //save last location

                form.Close();

                var newForm = new T();
                newForm.Show();
                newForm.Location = lastPosition;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             OpenWindow<ProductsDatabase>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenWindow<FoodCalculator>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenWindow<JournalWindow>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageData(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenWindow<SettingsWindow>();
        }

        public static void ManageData(bool serializeData = true)
        {
            FileDialog dialog;

            if (serializeData)
                dialog = new SaveFileDialog();
            else
                dialog = new OpenFileDialog();

            dialog.Filter = "database files (*.dtb)|*.dtb";
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + @"databases";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName != null)
                {
                    if (serializeData)
                        DatabaseSerializer.Serialize(dialog.FileName); //save all data to path
                    else
                    {
                        DatabaseSerializer.Deserialize(dialog.FileName); //load all data from path

                        //refresh windows

                        RefreshWindows<JournalWindow>();
                        RefreshWindows<ProductsDatabase>();
                        RefreshWindows<FoodCalculator>();
                    }
                }
            }
        }
    }
}
