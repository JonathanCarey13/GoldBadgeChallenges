using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoRepository
{
    public class ChallengeTwoClaimsRepository
    {
        private List<ChallengeTwoClaimsProperties> claims = new List<ChallengeTwoClaimsProperties>();

        public void AddNewClaim(ChallengeTwoClaimsProperties claim)
        {
            claims.Add(claim);
        }

        public List<ChallengeTwoClaimsProperties> ShowCurrentClaims()
        {
            return claims;
        }

        public List<ChallengeTwoClaimsProperties> SeeNextClaim()
        {
            return claims[0];
        }
    }
}
