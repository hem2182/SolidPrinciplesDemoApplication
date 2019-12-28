using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_DIP_Applied
{
    public class AutoPolicyRater : Rater
    {
        //public AutoPolicyRater(IRatingUpdator ratingUpdator) : base(ratingUpdator)
        //{
        //}
        public AutoPolicyRater(ILogger Logger) : base(Logger)
        {

        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Rating AUTO policy...");
            Logger.Log("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Logger.Log("Auto policy must specify Make");
                return 0m;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    //_ratingUpdator.UpdateRating(1000m);
                    return 1000m;
                }
                //_ratingUpdator.UpdateRating(900m);
                return 900m;
            }
            return 0m;
        }
    }
}
