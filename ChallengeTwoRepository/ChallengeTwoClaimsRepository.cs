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
        private Queue<ChallengeTwoClaimsProperties> claims = new Queue<ChallengeTwoClaimsProperties>();

        public void AddNewClaim(ChallengeTwoClaimsProperties claim)
        {
            claims.Enqueue(claim);
        }

        public Queue<ChallengeTwoClaimsProperties> ShowCurrentClaims()
        {
            return claims;
        }
    }
}
