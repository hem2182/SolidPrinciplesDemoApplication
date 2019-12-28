using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_ISP
{
    public class RaterFactory
    {
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
                return (Rater)Activator.CreateInstance(Type.GetType($"ArdalisRating_ISP.{policy.Type}PolicyRater"),
                        new object[] { context });
            }
            catch (Exception)
            {
                return new UnknownPolicyRater(context);
            }

        }
    }
}
