namespace ArdalisRating_DIP_Applied
{
    public abstract class Rater
    {
        //protected readonly IRatingUpdator _ratingUpdator;
        protected ILogger Logger { get; set; }

        public Rater(ILogger logger)
        {
            Logger = logger;
        }

        public abstract decimal Rate(Policy policy);
    }
}