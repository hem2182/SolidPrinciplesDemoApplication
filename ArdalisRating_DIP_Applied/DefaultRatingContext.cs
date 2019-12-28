namespace ArdalisRating_DIP_Applied
{
    internal class DefaultRatingContext : IRatingContext
    {
        private readonly IPolicySource _policySource;
        private readonly IPolicySerializer _policySerializer;
        public RatingEngine Engine { get; set; }

        public DefaultRatingContext(IPolicySource policySource, IPolicySerializer policySerializer)
        {
            _policySource = policySource;
            _policySerializer = policySerializer;
        }

        public Rater CreateRaterForPolicy(Policy policy, ILogger logger)
        {
            return new RaterFactory(logger).Create(policy);
        }

        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return _policySerializer.GetPolicyFromnString(policyJson);
        }

        public Policy GetPolicyFromXMLString(string policyXml)
        {
            throw new System.NotImplementedException();
        }

        public string LoadPolicyFromFile()
        {
            return _policySource.GetPolicyFromSource();
        }

        public string LoadPolicyFromURI(string uri)
        {
            throw new System.NotImplementedException();
        }

        public void Log(string message)
        {
            new ConsoleLogger().Log(message);
        }
    }
}