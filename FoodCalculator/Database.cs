using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FoodCalculator
{
    public class DatabaseSerializer
    {
        public static Database Database { get; set; } = new Database(); //database info
        public static List<DayInfo> CalendarProductsInfo { get; set; } = new List<DayInfo>(); //calendar info
        public static MealInfo CalculatorMealInfo { get; set; } = new MealInfo();

        public static string defaultPath = "databases\\database.dtb";

        public static void Serialize(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, Database);
            formatter.Serialize(stream, CalendarProductsInfo);
            formatter.Serialize(stream, CalculatorMealInfo);

            stream.Close();
        }

        public static void Deserialize(string path)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

                try
                {
                    Database = (Database)formatter.Deserialize(stream);
                    CalendarProductsInfo = (List<DayInfo>)formatter.Deserialize(stream);
                    CalculatorMealInfo = (MealInfo)formatter.Deserialize(stream);
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while loading the database, some data may not have been loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                stream.Close();
            }
            catch(IOException)
            {
                //MessageBox.Show("Nie znaleziono pliku bazy danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    /// <summary>
    /// List of anaviable products in database
    /// </summary>
    [Serializable]
    public class Database
    {
        public List<Product> Foods
        {
            get;
            set;
        } = new List<Product>();

    }

    public enum Measure
    {
        grams
    };

    [Serializable]
    public class Product : ICloneable
    {
        public string Name  { get; set; }

        public decimal Amount   { get; set; }
        public decimal Energy   { get; set; }
        public decimal Proteins { get; set; }
        public decimal Fats     { get; set; }
        public decimal Carbo    { get; set; }
        public decimal Sugars   { get; set; }
        public decimal Fibers   { get; set; }
        public decimal Salts    { get; set; }
        public Measure Measure  { get; set; }

        private int indexInCalculator;
        public int IndexInCalculator
        {
            get
            {
                return indexInCalculator;
            }
            set
            {
                indexInCalculator = value;
            }
        }

        public Product() {}

        public Product(string name,
                       decimal amount,
                       decimal energy,
                       decimal proteins,
                       decimal fats,
                       decimal carbo,
                       decimal sugars,
                       decimal fibers,
                       decimal salts,
                       Measure measure)
        {
            Name = name;
            Amount = amount;
            Energy = energy;
            Proteins = proteins;
            Fats = fats;
            Carbo = carbo;
            Sugars = sugars;
            Fibers = fibers;
            Salts = salts;
            Measure = measure;
        }

        public string ImageName { get; set; }


        public object Clone()
        {
            return 
                MemberwiseClone();
        }
    }
}
