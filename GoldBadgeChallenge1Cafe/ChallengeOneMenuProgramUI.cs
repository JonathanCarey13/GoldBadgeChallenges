using ChallengeOneMenuRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBadgeChallenge1Cafe
{
    class ChallengeOneMenuProgramUI
    {
        public void Run()
        {
            SeedMenuList();
            Menu();
        }
        
        private ChallengeOneRepository menuItems = new ChallengeOneRepository();

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Komodo Cafe Menu Manager:\n\n" +
                    "1. Create a new menu item\n" +
                    "2. View current menu items\n" +
                    "3. Find a specific menu item\n" +
                    "4. Delete a menu item\n" +
                    "5. Quit Program");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        ViewCurrentMenuItems();
                        break;
                    case "3":
                        FindSpecificMenuItem();
                        break;
                    case "4":
                        DeleteMenuItem();
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewMenuItem()
        {
            Console.Clear();
            ChallengeOneMenuProperties newMenuItem = new ChallengeOneMenuProperties();

            Console.WriteLine("Enter the new meal name:");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter the new meal's description:");
            newMenuItem.Description = Console.ReadLine();

            Console.WriteLine("Enter the new meal's ingredient list:");
            newMenuItem.IngredientList = Console.ReadLine();

            Console.WriteLine("Enter the new meal's number:");
            string newMenuItemNumberString = Console.ReadLine();
            newMenuItem.MealNumber = int.Parse(newMenuItemNumberString);

            Console.WriteLine("Enter the new meal's price:");
            string newMenuItemPriceString = Console.ReadLine();
            newMenuItem.Price = float.Parse(newMenuItemPriceString);

            menuItems.AddNewMenuItem(newMenuItem);

        }
        private void ViewCurrentMenuItems()
        {
            Console.Clear();
            List<ChallengeOneMenuProperties> menuItemsList = menuItems.ShowCurrentMenuItems();

            foreach (ChallengeOneMenuProperties menuItem in menuItemsList)
            {
                Console.WriteLine($"Meal Name: {menuItem.MealName}\n" +
                    $"Meal Description: {menuItem.Description}\n" +
                    $"Meal Ingredient List: {menuItem.IngredientList}\n" +
                    $"Meal Number: {menuItem.MealNumber}\n" +
                    $"Meal Price: {menuItem.Price}\n\n\n\n");
            }
        }
        private void FindSpecificMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of the meal you want to find.");

            string menuItemNumberString = Console.ReadLine();
            int menuItemNumberInt = int.Parse(menuItemNumberString);

            ChallengeOneMenuProperties menuItem = menuItems.FindSpecificMenuItem(menuItemNumberInt);

            if (menuItem != null)
            {
                Console.WriteLine($"Meal Name: {menuItem.MealName}\n" +
                    $"Meal Description: {menuItem.Description}\n" +
                    $"Meal Ingredient List: {menuItem.IngredientList}\n" +
                    $"Meal Number: {menuItem.MealNumber}\n" +
                    $"Meal Price: {menuItem.Price}\n\n");
            }
            else
            {
                Console.WriteLine("No content by that title.");
            }
        }
        private void DeleteMenuItem()
        {
            ViewCurrentMenuItems();

            Console.WriteLine("\nEnter the number of the meal you'd like to remove:");

            string mealNumberString = Console.ReadLine();
            int mealNumberInt = int.Parse(mealNumberString);

            bool wasDeleted = menuItems.RemoveMenuItem(mealNumberInt);

            if (wasDeleted)
            {
                Console.WriteLine("The menu item was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The menu item could not be deleted.");
            }
        }
        private void SeedMenuList()
        {
            ChallengeOneMenuProperties cheeseBurger = new ChallengeOneMenuProperties("Cheeseburger Meal", "A classic burger with cheese and all the fixin's.", "Meat, Cheese, Lettuce, Tomato, Pickles", 1, 9.95);
            ChallengeOneMenuProperties portabellaBurger = new ChallengeOneMenuProperties("Portabellaburger Meal", "A vegan burger that uses a portabella mushroom for the patty.", "Portabella Mushroom, Lettuce, Tomato, Pickles", 2, 11.95);
            ChallengeOneMenuProperties salad = new ChallengeOneMenuProperties("Salad Meal", "Spring salad mix with toppings and Balsamic Vinegar.", "Red Onions, Cheese, Crutons, Cherry Tomatos", 3, 8.95);

            menuItems.AddNewMenuItem(cheeseBurger);
            menuItems.AddNewMenuItem(portabellaBurger);
            menuItems.AddNewMenuItem(salad);
        }
    }

}
    

