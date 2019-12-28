namespace ArdalisRating_Organized
{
    internal class FloodPolicyRater : Rater
    {
        //public FloodPolicyRater(IRatingUpdator ratingUpdator) : base(ratingUpdator)
        //{
        //}
        public FloodPolicyRater(ILogger Logger) : base(Logger)
        {

        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Rating FLOOD policy...");
            Logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Logger.Log("FLood policy must specify Bond Amount and Valuation.");
                return 0;
            }
            if (policy.ElevationAboveSeaLevelFeet <= 0)
            {
                Logger.Log("Flood policy is not available for elevations at or below sea levels.");
                return 0;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Logger.Log("Insufficient bond amount.");
                return 0;
            }
            decimal multiple = 1.0m;
            if (policy.ElevationAboveSeaLevelFeet <= 100)
            {
                multiple = 2.0m;
            }
            else if (policy.ElevationAboveSeaLevelFeet <= 500)
            {
                multiple = 1.5m;
            }
            else if (policy.ElevationAboveSeaLevelFeet <= 1000)
            {
                multiple = 1.1m;
            }
            //_ratingUpdator.UpdateRating(policy.BondAmount * 0.05m * multiple);
            return policy.BondAmount * 0.05m * multiple;
        }
    }
}