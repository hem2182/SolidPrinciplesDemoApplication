namespace ArdalisRating_ISP_Applied
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(IRatingUpdator ratingUpdator) : base(ratingUpdator)
        {
        }

        public override void Rate(Policy policy)
        {
            Logger.Log("Unknown Policy Type");
        }
    }
}