using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeOneTests
{
    [TestClass]
    public class ChallengeOneRepository
    {
        private List<ChallengeOneMenuProperties> menuItems = new List<ChallengeOneMenuProperties>();

        [TestMethod]
        public void AddNewMenuItem(string menuItem)
        {
            menuItems.Add(menuItem);
        }

        [TestMethod]
        public void List<ChallengeOneMenuProperties> ShowCurrentMenuItems()
        {
            return menuItems;
        }

        [TestMethod]
        public bool UpdateCurrentMenuItem(string originalMealNumber, ChallengeOneMenuProperties newMealNumber)
        {
            ChallengeOneMenuProperties oldMealNumber = FindSpecificMenuItem(int.Parse(originalMealNumber));

            if (oldMealNumber != null)
            {
                oldMealNumber.MealName = newMealNumber.MealName;
                oldMealNumber.Description = newMealNumber.Description;
                oldMealNumber.IngredientList = newMealNumber.IngredientList;
                oldMealNumber.MealNumber = newMealNumber.MealNumber;
                oldMealNumber.Price = newMealNumber.Price;
                return true;
            }
            else
            {
                return false;
            }
        }

        [TestMethod]
        public bool RemoveMenuItem(int mealNumber)
        {
            ChallengeOneMenuProperties menuItem = FindSpecificMenuItem(mealNumber);

            if (menuItem == null)
            {
                return false;
            }
            int initialCount = menuItems.Count;
            menuItems.Remove(menuItem);

            if (initialCount > menuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [TestMethod]
        public void FindSpecificMenuItem(int mealNumber)
        {
            foreach (ChallengeOneMenuProperties mealItem in menuItems)
            {
                if (mealItem.MealNumber == mealNumber)
                {
                    return mealItem;
                }
            }
            return null;
        }
    }
}
