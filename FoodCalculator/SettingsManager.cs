using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FoodCalculator
{
    public class SettingsManager
    {
        private static SettingsManager instance;

        public static SettingsManager GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SettingsManager();
                }

                return instance;
            }
        }

        public Settings settings = new Settings();
        public static bool Changed { get; set; }

        //class contains controls colors
        [Serializable]
        public class Settings
        {
            public Color BackgroundColor { get; set; } = Color.White;
            public Color BackgroundTextColor { get; set; } = Color.Black;

            public Color ButtonsColor { get; set; } = Color.White;
            public Color ButtonsTextColor { get; set; } = Color.Black;

            public Color PanelsBackgorundColor { get; set; } = Color.White;
            public Color PanelsTextColor { get; set; } = Color.Black;

            public Color ProductColumnColor { get; set; } = Color.White;
            public Color ProductTextColor { get; set; } = Color.Black;

            public Color MealColumnColor { get; set; } = Color.Red;
            public Color MealTextColor { get; set; } = Color.White;

            public Color SumColumnColor { get; set; } = Color.DarkBlue;
            public Color WholeSumColumnColor { get; set; } = Color.DarkRed;

            public Color SumColumnTextColor { get; set; } = Color.White;
            public Color WholeSumColumnTextColor { get; set; } = Color.White;

            public bool Autosave { get; set; }
        }

        public enum ColorType
        {
            Background,
            BackgroundText,
            Buttons,
            ButtonsText,
            Panels,
            PanelsText,
            ProductColumns,
            ProductColumnsText,
            MealColumns,
            MealColumnsText,
            SumColumns,
            SumColumnsText,
            WholeSumColumns,
            WholeSumColumnsText
        }

        public void MakeAutosave()
        {
            if(settings.Autosave)
            {
                DatabaseSerializer.Serialize(DatabaseSerializer.defaultPath);
                //MessageBox.Show("zrobiłem zapis!");
            }
        }

        public void SaveSettings()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("settings.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, settings);
            stream.Close();
        }

        public void LoadSettings()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("settings.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

                try
                {
                    settings = (Settings)formatter.Deserialize(stream);
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while opening a database file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                stream.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("An error occurred while opening the settings file, the default settings will be applied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}