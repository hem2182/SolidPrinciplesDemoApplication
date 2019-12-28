namespace ArdalisRating_ISP_Applied
{
    public abstract class Rater
    {
        protected readonly IRatingUpdator _ratingUpdator;
        protected ILogger Logger { get; set; } = new ConsoleLogger();

        public Rater(IRatingUpdator ratingUpdator)
        {
            _ratingUpdator = ratingUpdator;
        }

        public abstract void Rate(Policy policy);
    }
}