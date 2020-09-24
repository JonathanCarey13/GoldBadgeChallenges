using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOneMenuRepository
{
    public class ChallengeOneRepository
    {
        //List containing all menu items to be used in the ChallengeOneProgramUI
        private List<ChallengeOneMenuProperties> menuItems = new List<ChallengeOneMenuProperties>();

        //This method creates a new menu item for Komodo and adds it to the current menu item list
        public void AddNewMenuItem(ChallengeOneMenuProperties menuItem)
        {
            menuItems.Add(menuItem);
        }

        //This method returns the list of all current menu items
        public List<ChallengeOneMenuProperties> ShowCurrentMenuItems()
        {
            return menuItems;
        }

        //This method finds a menu item by it's number, then lets the user update or edit any current menu item's meal number, meal name, description, list of ingredients and price
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

        //This methods finds
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

        //This method goes through the list of menu items and finds a menu item's number, compares the number to make sure it matches, then returns the meal item
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
