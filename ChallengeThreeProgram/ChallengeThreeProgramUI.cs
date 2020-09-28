﻿using ChallengeThreeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeProgram
{
    public class ChallengeThreeProgramUI
    {

        public void Run()
        {
            Menu();
        }

        private ChallengeThreeBadgesRepository badges = new ChallengeThreeBadgesRepository();

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
        
        public void AddBadge()
        {
            Console.Clear();
            ChallengeThreeBadgesProperties newBadge = new ChallengeThreeBadgesProperties();

            Console.WriteLine("Enter the new badge ID number:");
            string badgeIDAsString = Console.ReadLine();
            int BadgeIDAsInt = int.Parse(badgeIDAsString);
            newBadge.BadgeID = BadgeIDAsInt;

            Console.WriteLine("Enter a door the badge needs access to:");
            string badgeDoor = Console.ReadLine();
            List<string> = badgeDoor;


            
        }

        public void EditBadge()
        {

        }

        public void ListBadges()
        {

        }
    }
}
