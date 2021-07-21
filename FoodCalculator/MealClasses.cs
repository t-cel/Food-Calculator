using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodCalculator
{
    /// <summary>
    /// Day data
    /// </summary>
    [Serializable]
    public class DayInfo
    {
        public MealInfo mealsInfo { get; set; } = new MealInfo();
        public DateTime date;

        public DayInfo(DateTime dayInfoDate)
        {
            date = dayInfoDate;
        }
    }

    /// <summary>
    /// Meals data
    /// </summary>
    [Serializable]
    public class MealInfo
    {
        public static string[] mealNames = { "Breakfast", "Second Breakfast", "Snack", "Lunch", "Afternoon Snack", "Dinner" };
        public Dictionary<string, Meal> Meals { get; set; } = new Dictionary<string, Meal>();

        public MealInfo()
        {
            foreach (string mealName in MealInfo.mealNames)
            {
                Meals.Add(mealName, new Meal());
            }
        }
    }

    /// <summary>
    /// Describing meals
    /// </summary>
    [Serializable]
    public class Meal
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public decimal[] GetSumOfAllProductsProperties()
        {
            return new decimal[]
            {
                Products.Sum(m => m.Amount),
                Products.Sum(m => m.Proteins),
                Products.Sum(m => m.Fats),
                Products.Sum(m => m.Carbo),
                Products.Sum(m => m.Sugars),
                Products.Sum(m => m.Fibers),
                Products.Sum(m => m.Salts),
                Products.Sum(m => m.Energy),
            };
        }
    }
}
