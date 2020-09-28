using ChallengeTwoRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoProgram
{
    class ChallengeTwoProgramUI
    {
        public void Run()
        {
            CurrentClaimsList();
            Menu();
        }

        private ChallengeTwoClaimsRepository claims = new ChallengeTwoClaimsRepository();

        private void Menu()
        {
            Console.Clear();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Komodo Claims:\n\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Quit Program");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        NextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
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
        private void CreateNewClaim()
        {
            Console.Clear();
            ChallengeTwoClaimsProperties newClaim = new ChallengeTwoClaimsProperties();

            Console.WriteLine("Enter the new claim's ID number:");
            newClaim.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new claim's type:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");

            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            newClaim.Type = (ClaimType)typeAsInt;

            Console.WriteLine("Enter the description of the new claim:");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the new claim amount");
            string amountAsString = Console.ReadLine();
            double amountAsF = double.Parse(amountAsString);
            newClaim.Amount = amountAsF;

            Console.WriteLine("Enter the date of the accident as (month/day/year) like: 08/23/2020, etc..");
            string accidentDateAsString = Console.ReadLine();
            DateTime accidentDateAsDateTime = DateTime.Parse(accidentDateAsString);
            newClaim.DateOfAccident = accidentDateAsDateTime;

            Console.WriteLine("Enter the date the claim was made as (month/day/year) like: 03/21/1995, etc..");
            string claimCreationDateAsString = Console.ReadLine();
            DateTime claimCreationDateAsDateTime = DateTime.Parse(claimCreationDateAsString);
            newClaim.DateOfClaim = claimCreationDateAsDateTime;

            Console.WriteLine("Was the claim valid, eg: was it made within 30 days of the accident date?\n" +
                "Y or N?");
            string isValid = Console.ReadLine().ToLower();

            if (isValid == "y")
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }
            
            claims.AddNewClaim(newClaim);
        }
        private void ViewAllClaims()
        {
            Console.Clear();
            Queue<ChallengeTwoClaimsProperties> claimsList = claims.ShowCurrentClaims();
            foreach (ChallengeTwoClaimsProperties claim in claimsList)
            {
                Console.WriteLine($"ClaimID:{claim.ID}\n" +
                    $"Type: {claim.Type}\n" +
                    $"Description: {claim.Description}\n" +
                    $"Amount: {claim.Amount}\n" +
                    $"Date of Accident: {claim.DateOfAccident}\n" +
                    $"Date of Claim: {claim.DateOfClaim}\n" +
                    $"Is Valid: {claim.IsValid}\n\n");
            }
        }
        private void NextClaim()
        {
            Console.Clear();
            Queue<ChallengeTwoClaimsProperties> nextClaim = claims.ShowCurrentClaims();

            Console.WriteLine($"Claim ID: {nextClaim.Peek().ID}");
            Console.WriteLine($"Type: {nextClaim.Peek().Type}");
            Console.WriteLine($"Description: {nextClaim.Peek().Description}");
            Console.WriteLine($"Amount: {nextClaim.Peek().Amount}");
            Console.WriteLine($"Date of Accident: {nextClaim.Peek().DateOfAccident}");
            Console.WriteLine($"Date of Claim: {nextClaim.Peek().DateOfClaim}");
            Console.WriteLine($"Is Valid: {nextClaim.Peek().IsValid}");

            Console.WriteLine("Do you want to deal with this claim now? (Y/N)");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                nextClaim.Dequeue();
            }
            else
            {
                Menu();
            }

        }
        private void CurrentClaimsList()
        {
            ChallengeTwoClaimsProperties frodo = new ChallengeTwoClaimsProperties(1, ClaimType.Car, "Car accident on 465.", 400.00, new DateTime(04/25/18), new DateTime (04/27/18), true );
            ChallengeTwoClaimsProperties gandolf = new ChallengeTwoClaimsProperties(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime (04/11/18), new DateTime (04/12/18), true);
            ChallengeTwoClaimsProperties sam = new ChallengeTwoClaimsProperties(3, ClaimType.Theft, "Stolen pancakes", 4.00, new DateTime (04/27/18), new DateTime (06/01/18), false);

            claims.AddNewClaim(frodo);
            claims.AddNewClaim(gandolf);
            claims.AddNewClaim(sam);
        }
    }
}
