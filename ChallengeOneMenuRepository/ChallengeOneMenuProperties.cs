using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneMenuRepository
{
    public class ChallengeOneMenuProperties
    {
        public string MealName { get; set; }
        public string Description { get; set; }
        public string IngredientList { get; set; }
        public int MealNumber { get; set; }
        public double Price { get; set; }

        public ChallengeOneMenuProperties() { }

        public ChallengeOneMenuProperties(string mealName, string description, string ingredients, int mealNumber, double price)
        {
            MealName = mealName;
            Description = description;
            IngredientList = ingredients;
            MealNumber = mealNumber;
            Price = price;
        }
    }
}
