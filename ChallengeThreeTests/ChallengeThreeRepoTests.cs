using System;
using System.Collections.Generic;
using ChallengeThreeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeThreeTests
{
    [TestClass]
    public class ChallengeThreeRepoTests
    {
        Dictionary<int, Badge> badges = new Dictionary<int, Badge>() { };

        [TestMethod]
        public void SeedBadgesToDictionary()
        {
            badges.Add(123, new Badge(001, new List<string> { "A1", "A2", "A3", "A4" }, "A Badge"));
            badges.Add(345, new Badge(002, new List<string> { "A1", "A2", "B3" }, "A Badge"));
            badges.Add(678, new Badge(001, new List<string> { "B1" }, "B Badge"));
            badges.Add(987, new Badge(001, new List<string> { "C1", "A1", "A2" }, "C Badge"));
        }

        [TestMethod]
        public void AddNewBadge(Badge newBadge)
        {
            badges.Add(newBadge.BadgeID, newBadge);
        }

        [TestMethod]
        public bool DeleteBadge(int ID)
        {

            Badge badge = GetBadgeID(ID);
            int initialCount = badge.Doors.Count;
            if (badge.BadgeID == ID)
            {
                badge.Doors = new List<string>() { };
            }
            else
            {
                Console.WriteLine("There's no badge with that ID.");
            }
            if (initialCount > badge.Doors.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [TestMethod]
        public Badge GetBadgeID(int badgeID)
        {
            foreach (KeyValuePair<int, Badge> badge in badges)
            {
                if (badge.Key == badgeID)
                {
                    return badge.Value;
                }
            }
            return null;
        }
    }
}
