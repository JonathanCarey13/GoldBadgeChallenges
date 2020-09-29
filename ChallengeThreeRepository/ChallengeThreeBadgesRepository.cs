using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeRepository
{
    public class ChallengeThreeBadgesRepository
    {
        
        public Dictionary<int, ChallengeThreeBadgesProperties> badges = new Dictionary<int, ChallengeThreeBadgesProperties>
        {
            {1001, A1 },
            {1002, A2 },
            {2001, B1 },
            {3001, C1 },
        };

        public static ChallengeThreeBadgesProperties A1 = new ChallengeThreeBadgesProperties(
            1001,
            new List<string> { "A1", "A2" },
            "A Badge"
            );
        public static ChallengeThreeBadgesProperties A2 = new ChallengeThreeBadgesProperties(
            1002,
            new List<string> { "A1", "A2" },
            "A Badge"
            ); 
        public static ChallengeThreeBadgesProperties B1 = new ChallengeThreeBadgesProperties(
             2001,
             new List<string> { "B1" },
             "B Badge"
             );
        public static ChallengeThreeBadgesProperties C1 = new ChallengeThreeBadgesProperties(
            3001,
            new List<string> {  "A1", "A2", "B1", "C1",},
            "C Badge"
            );

        public void AddNewBadge()
        {
            badges.Add(newBadge);
        }
    }
}
