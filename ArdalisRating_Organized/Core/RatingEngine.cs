using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating_Organized
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        private readonly ILogger _logger;
        private readonly IPolicySource _policySource;
        private readonly IPolicySerializer _policySerializer;
        private RaterFactory _raterFactory { get; set; }
        //public IRatingContext Context { get; set; }


        //public RatingEngine() : this(new ConsoleLogger())
        //{
        //    //Constructor chaining to the parameterized ILogger constructor below. 
        //}

        public RatingEngine(ILogger logger, IPolicySource policySource, IPolicySerializer policySerializer, RaterFactory raterFactory)
        {
            _logger = logger;
            _policySource = policySource;
            _policySerializer = policySerializer;
            _raterFactory = raterFactory;
            //Context = new DefaultRatingContext(_policySource, policySerializer);
            //Context.Engine = this;
        }


        public decimal Rating { get; set; }
        public void Rate()
        {
            _logger.Log("Starting rate.");
            _logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyString = _policySource.GetPolicyFromSource();
            var policy = _policySerializer.GetPolicyFromnString(policyString);
            //var rater = Context.CreateRaterForPolicy(policy, _logger);
            var rater = _raterFactory.Create(policy);
            Rating = rater.Rate(policy);

            _logger.Log("Rating completed.");
        }
    }
}