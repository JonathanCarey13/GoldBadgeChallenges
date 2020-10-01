using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeRepository
{
    public class ChallengeThreeBadgesRepository
    {
        private Dictionary<int, ChallengeThreeBadgesProperties> _badges = new Dictionary<int, ChallengeThreeBadgesProperties>();

        public void SeedBadges()
        {
            _badges.Add(1001, new ChallengeThreeBadgesProperties(1001, new List<string> { "A1", "A2" }, "A Badge"));
            _badges.Add(1002, new ChallengeThreeBadgesProperties(1002, new List<string> { "A1", "A2" }, "A Badge"));
            _badges.Add(2001, new ChallengeThreeBadgesProperties(2001, new List<string> { "B1" }, "B Badge"));
            _badges.Add(3001, new ChallengeThreeBadgesProperties(3001, new List<string> { "C1", "A1", "A2" }, "C Badge"));
        }
        public void AddNewBadge(ChallengeThreeBadgesProperties newBadge)
        {
            _badges.Add(newBadge.BadgeID, newBadge);  //come back to this and explore around with this
        }
        public ChallengeThreeBadgesProperties ShowAllBadges(ChallengeThreeBadgesProperties badges)
        {
            return badges;
        }
    }
}
