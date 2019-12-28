namespace ArdalasInsuranceRatingEngine_SOLID
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(RatingEngine engine, ConsoleLogger logger) : base(engine, logger)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown Policy Type");
        }
    }
}