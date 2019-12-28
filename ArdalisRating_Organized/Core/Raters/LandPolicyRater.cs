using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_Organized
{
    public class LandPolicyRater : Rater
    {
        //public LandPolicyRater(IRatingUpdator ratingUpdator) : base(ratingUpdator)
        //{
        //}
        public LandPolicyRater(ILogger Logger): base(Logger)
        {

        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Rating LAND policy...");
            Logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Logger.Log("Land policy must specify Bond Amount and Valuation.");
                return 0m;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Logger.Log("Insufficient bond amount.");
                return 0m;
            }
            //_ratingUpdator.UpdateRating(policy.BondAmount * 0.05m);
            return policy.BondAmount * 0.05m;
        }
    }
}
