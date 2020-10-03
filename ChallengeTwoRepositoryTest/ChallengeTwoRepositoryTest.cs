using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeTwoRepositoryTest
{
    [TestClass]
    public class ChallengeTwoRepositoryTest
    {
        public Queue<ChallengeTwoRepositoryTest> repo = new Queue<ChallengeTwoRepositoryTest>();

        enum ClaimType {Car, Truck, Stuff }

        int iD = 1;
        ClaimType type = ClaimType.Stuff;
        string description = "asdfasdf";
        double amount = 333;
        DateTime dateOfAccident = new DateTime(2020, 03, 15);
        DateTime dateOfClaim = new DateTime(2020, 05, 15);
        bool isValid = true;

        [TestMethod]
        public void AddNewClaim()
        {
            int count = repo.Count;
            Assert.AreEqual(7, count);
        }

    }
}
