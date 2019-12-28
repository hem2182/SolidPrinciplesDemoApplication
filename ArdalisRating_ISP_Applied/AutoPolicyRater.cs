using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_ISP_Applied
{
    public class AutoPolicyRater : Rater
    {
        public AutoPolicyRater(IRatingUpdator ratingUpdator) : base(ratingUpdator)
        {
        }

        public override void Rate(Policy policy)
        {
            Logger.Log("Rating AUTO policy...");
            Logger.Log("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Logger.Log("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _ratingUpdator.UpdateRating(1000m);
                    return;
                }
                _ratingUpdator.UpdateRating(900m);
            }
        }
    }
}
