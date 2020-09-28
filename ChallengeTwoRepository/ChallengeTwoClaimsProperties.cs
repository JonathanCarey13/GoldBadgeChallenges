using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoRepository
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft,
    }
    public class ChallengeTwoClaimsProperties
    {
        public int ID { get; set; }
        public ClaimType Type { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public ChallengeTwoClaimsProperties() { }

        public ChallengeTwoClaimsProperties(int iD, ClaimType type, string description, double amount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ID = iD;
            Type = type;
            Description = description;
            Amount = amount;
            DateOfAccident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
