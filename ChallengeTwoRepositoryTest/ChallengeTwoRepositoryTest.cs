using System;
using System.Collections.Generic;
using ChallengeTwoRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeTwoRepositoryTest
{
    [TestClass]
    public class ChallengeTwoRepositoryTest
    {
        private Queue<ChallengeTwoClaimsProperties> claims = new Queue<ChallengeTwoClaimsProperties>();

        [TestMethod]
        public void ConstructorDisplaysCorrectType()
        {
            int iD = 1;
            ClaimType type = ClaimType.Car;
            string description = "asdfasdf";
            double amount = 333;
            DateTime dateOfAccident = new DateTime(2020, 03, 15);
            DateTime dateOfClaim = new DateTime(2020, 05, 15);
            bool isValid = true;

            ChallengeTwoClaimsProperties testClaim = new ChallengeTwoClaimsProperties(iD, type, description, amount, dateOfAccident, dateOfClaim, isValid);

            Assert.AreEqual(iD, testClaim.ID);
            Assert.AreEqual(type, testClaim.Type);
            Assert.AreEqual(description, testClaim.Description);
            Assert.AreEqual(amount, testClaim.Amount);
            Assert.AreEqual(dateOfAccident, testClaim.DateOfAccident);
            Assert.AreEqual(dateOfClaim, testClaim.DateOfClaim);
            Assert.AreEqual(isValid, testClaim.IsValid);
        }
        [TestMethod]
        public void AddNewClaim(ChallengeTwoClaimsProperties claim)
        {
            claims.Enqueue(claim);
        }
        [TestMethod]
        public Queue<ChallengeTwoClaimsProperties> ShowCurrentClaims()
        {
            return claims;
        }
    }
}
