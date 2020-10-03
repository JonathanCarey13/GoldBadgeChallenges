using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeRepository
{
    public class ChallengeThreeBadgesRepository
    {
        Dictionary<int, Badge> badges = new Dictionary<int, Badge>() { };

        public void SeedBadges()
        {
            badges.Add(1001, new Badge(1001, new List<string> { "A1", "A2" }, "A Badge"));
            badges.Add(1002, new Badge(1002, new List<string> { "A1", "A2" }, "A Badge"));
            badges.Add(2001, new Badge(2001, new List<string> { "B1" }, "B Badge"));
            badges.Add(3001, new Badge(3001, new List<string> { "C1", "A1", "A2" }, "C Badge"));
        }
        public void AddNewBadge(Badge newBadge)
        {
            badges.Add(newBadge.BadgeID, newBadge);  //come back to this and explore around with this
        }
        public List<Badge> GetAllBadges()
        {
            var items = badges.Values.ToList();
            return items;
        }
        public bool DeleteBadge(int ID)
        {
            Badge badge = GetBadgeByID(ID);
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

        public List<Badge> GetBadgeID()
        {
            int iD = badges.Keys.ToList();
            return iD;
        }

        //public bool RemoveBadge(Badge badge)
        //{
        //    List<Badge> badgeValueList = badges.Values.ToList();

        //    if (badge == null)
        //    {
        //        return false;
        //    }
        //    int initialCount = badges.Count;

        //    if (initialCount > badges.Count)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
