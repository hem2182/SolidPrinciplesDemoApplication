using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_ISP_Applied
{
    public class LandPolicyRater : Rater
    {
        public LandPolicyRater(IRatingUpdator ratingUpdator) : base(ratingUpdator)
        {
        }

        public override void Rate(Policy policy)
        {
            Logger.Log("Rating LAND policy...");
            Logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Logger.Log("Land policy must specify Bond Amount and Valuation.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Logger.Log("Insufficient bond amount.");
                return;
            }
            _ratingUpdator.UpdateRating(policy.BondAmount * 0.05m);
        }
    }
}
