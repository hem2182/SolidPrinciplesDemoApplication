using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_ISP_Applied
{
    public class RaterFactory
    {
        private readonly IRatingUpdator ratingUpdator;
        public Rater Create(Policy policy, IRatingContext context)
        {
            //switch (policy.Type)
            //{
            //    case PolicyType.Auto:
            //        return new AutoPolicyRater(engine, engine.Logger);
            //    case PolicyType.Flood:
            //        return new FloodPolicyRater(engine, engine.Logger);
            //    case PolicyType.Land:
            //        return new LandPolicyRater(engine, engine.Logger);
            //    case PolicyType.Life:
            //        return new LifePolicyRater(engine, engine.Logger);
            //    default:
            //        // TODO: Implement Null Object Pattern
            //        //Logger.Log("Unknown policy type");
            //        return new UnknownPolicyRater(engine, engine.Logger);
            //}

            // implementing through Reflection
            try
            {
                var a = (Rater)Activator.CreateInstance(Type.GetType($"ArdalisRating_ISP_Applied.{policy.Type}PolicyRater"),
                        new object[] { new RatingUpdator(context.Engine) });
                return a;
            }
            catch (Exception)
            {
                return new UnknownPolicyRater(new RatingUpdator(context.Engine));
            }

        }
    }
}
