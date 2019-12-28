using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalasInsuranceRatingEngine_SOLID
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
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
                return (Rater)Activator.CreateInstance(Type.GetType($"ArdalasInsuranceRatingEngine_SOLID.{policy.Type}PolicyRater"),
                        new object[] { engine, engine.Logger });
            }
            catch (Exception)
            {
                return new UnknownPolicyRater(engine, engine.Logger);
            }

        }
    }
}
