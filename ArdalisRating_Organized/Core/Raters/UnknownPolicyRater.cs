namespace ArdalisRating_Organized
{
    public class UnknownPolicyRater : Rater
    {
        //public UnknownPolicyRater(IRatingUpdator ratingUpdator) : base(ratingUpdator)
        //{
        //}
        public UnknownPolicyRater(ILogger Logger) : base(Logger)
        {

        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Unknown Policy Type");
            return 0m;
        }
    }
}