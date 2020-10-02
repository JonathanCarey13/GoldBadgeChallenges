using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOneMenuRepository
{
    public class ChallengeOneRepository
    {
        private List<ChallengeOneMenuProperties> menuItems = new List<ChallengeOneMenuProperties>();

        public void AddNewMenuItem(ChallengeOneMenuProperties menuItem)
        {
            menuItems.Add(menuItem);
        }

        public List<ChallengeOneMenuProperties> ShowCurrentMenuItems()
        {
            return menuItems;
        }

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

        public ChallengeOneMenuProperties FindSpecificMenuItem(int mealNumber)
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
