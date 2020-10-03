using ChallengeThreeRepository;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChallengeThreeProgram
{
    public class ChallengeThreeProgramUI
    {

        public void Run()
        {
            _badges.SeedBadges();
            Menu();
        }

        private ChallengeThreeBadgesRepository _badges = new ChallengeThreeBadgesRepository();

        private void Menu()
        {
            Console.Clear();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Komodo Badge Access Manager:\n\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n" +
                    "4. Quit Program");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListBadges();
                        break;
                    case "4":
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
        private void AddBadge()
        {
            Console.Clear();
            Badge newBadge = new Badge();

            Console.WriteLine("Enter the new badge ID number:");
            string badgeIDAsString = Console.ReadLine();
            int BadgeIDAsInt = int.Parse(badgeIDAsString);
            newBadge.BadgeID = BadgeIDAsInt;

            Console.WriteLine("Enter a door the badge needs access to:");
            newBadge.Doors = new List<string>();
            string newDoor = Console.ReadLine();
            newBadge.Doors.Add(newDoor);

            bool doorLoop = true;

            while (doorLoop)
            {
                Console.WriteLine("Do you want to add another door? Y/N ");
                newDoor = Console.ReadLine().ToLower();
                Console.Clear();
                if (newDoor == "y")
                {
                    Console.WriteLine("Enter a door the badge needs access to:");
                    newBadge.Doors.Add(Console.ReadLine());
                }
                else if (newDoor == "n")
                {
                    doorLoop = false;
                }
                else
                {
                    Console.WriteLine("Please enter Y or N");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine("Enter the badge name: ");
            newBadge.BadgeName = Console.ReadLine();

            _badges.AddNewBadge(newBadge);
        }

        private void ListBadges()
        {
            Console.Clear();
            List<Badge> badges = _badges.GetBadgeValues();

            foreach (Badge item in badges)
            {
                if (item != null)
                {
                    string joined = string.Join(",", item.Doors);
                    string.Join(", ", badges);
                    Console.WriteLine($"Badge ID:{item.BadgeID}\n" +
                        $"Badge Access Door(s):{joined}\n" +
                        $"Badge Name:{item.BadgeName}\n\n");
                }
            }
                Console.ReadKey();
        }
        private void EditBadge()
        {
            Console.Clear();

            Badge newBadge = new Badge();

            Console.WriteLine("Which badge ID would you like to update? ");
            string input = Console.ReadLine();
            if (input.Contains($"{newBadge.BadgeID}"))
            {
                Console.WriteLine("What would you like to do?\n" +
                    "1. Remove a door\n" +
                    "2. Add a door");

                string secondInput = Console.ReadLine().ToLower();
                switch (secondInput)
                {
                    case "1":
                        int badgeID = int.Parse(Console.ReadLine());
                        Badge badge = _badges.GetBadgeID(badgeID);
                        _badges.DeleteBadge(badgeID);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter a door the badge needs access to:");
                        newBadge.Doors = new List<string>();
                        string newDoor = Console.ReadLine();
                        newBadge.Doors.Add(newDoor);
                        Console.Clear();
                        Console.WriteLine($"{newBadge.BadgeID} now has access to door: {newBadge.Doors}.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Please enter 1 or 2");
                        break;
                }

            }
        }
    }
}

