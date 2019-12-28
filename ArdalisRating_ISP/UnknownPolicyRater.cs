namespace ArdalisRating_ISP
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(IRatingContext context) : base(context)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown Policy Type");
        }
    }
}