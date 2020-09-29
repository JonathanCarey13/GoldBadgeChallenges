using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeRepository
{
    public class ChallengeThreeBadgesProperties
    {
        public int BadgeID { get; set; }
        public List<string> Doors { get; set; } /*= new List<string>();  This is one example of creating a default for an instance of this list*/
        public string BadgeName { get; set; }

        public ChallengeThreeBadgesProperties() { }

        public ChallengeThreeBadgesProperties(int badgeID, List<string> doors, string badgeName)
        {
            BadgeID = badgeID;
            Doors = doors;
            BadgeName = badgeName;
        }

    }
}
