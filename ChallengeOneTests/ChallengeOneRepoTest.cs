using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeOneTests
{
    [TestClass]
    public class ChallengeOneRepository
    {
        public ChallengeOneRepository(string mealName, string description, string ingredientList, int mealNumber, double price)
        {
            MealName = mealName;
            Description = description;
            IngredientList = ingredientList;
            MealNumber = mealNumber;
            Price = price;
        }

        public ChallengeOneRepository()
        {
        }

        public string MealName { get; }
        public string Description { get; }
        public string IngredientList { get; }
        public int MealNumber { get; }
        public double Price { get; }

        //public void MyTestMethod()
        //{
        //    Arrange
        //    Make an instance of the repository
        //    Make an instance of the business object
        //    Get the count before we act

        //     Act
        //     Run the add method

        //     Assert
        //     that the count of the list in the repository is greater than
        //     the initial count
        //     check that the first business object in your "Get all" method
        //     is the object you just added
        //}

        [TestMethod]
        public void ConstructorDisplaysCorrectType()
        {
            string mealName = "test name";
            string description = "asdfasdf";
            string ingredientList = "zxcvzxcv";
            int mealNumber = 5;
            double price = 3.56;

            ChallengeOneRepository testMenu = new ChallengeOneRepository(mealName, description, ingredientList, mealNumber, price);


            Assert.AreEqual(mealName, MealName);
            Assert.AreEqual(description, Description);
            Assert.AreEqual(ingredientList, IngredientList);
            Assert.AreEqual(mealNumber, MealNumber);
            Assert.AreEqual(price, Price);
        }

        [TestMethod]
        public void AddNewMenuItem(string testItem)
        {
            List<ChallengeOneRepository> menuItems = new List<ChallengeOneRepository>();
            menuItems.Add(testItem);
        }

        [TestMethod]
        public void List<ChallengeOneMenuProperties> ShowCurrentMenuItems()
        {
            return menuItems;
        }

        [TestMethod]
        public bool UpdateCurrentMenuItem(string originalMealNumber, ChallengeOneRepository newMealNumber)
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
            ChallengeOneRepository menuItem = FindSpecificMenuItem(mealNumber);

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
            foreach (ChallengeOneRepository mealItem in ChallengeOneRepository)
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
