namespace ArdalisRating_ISP_Applied
{
    internal class RatingUpdator : IRatingUpdator
    {
        private readonly RatingEngine _ratingEngine;
        public RatingUpdator(RatingEngine ratingEngine)
        {
            _ratingEngine = ratingEngine;
        }

        public void UpdateRating(decimal rating)
        {
            _ratingEngine.Rating = rating;
        }
    }
}