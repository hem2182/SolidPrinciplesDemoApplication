namespace ArdalisRating_ISP
{
    public abstract class Rater
    {
        protected readonly IRatingContext _context;
        protected ConsoleLogger _logger;

        public Rater(IRatingContext context)
        {
            _context = context;
            _logger = context.Logger;
        }

        public abstract void Rate(Policy policy);
    }
}