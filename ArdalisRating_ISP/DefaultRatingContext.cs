namespace ArdalisRating_ISP
{
    internal class DefaultRatingContext : IRatingContext
    {
        public RatingEngine Engine { get; set; }

        public ConsoleLogger Logger => new ConsoleLogger();

        public Rater CreateRaterForPolicy(Policy policy, IRatingContext context)
        {
            return new RaterFactory().Create(policy, context);
        }

        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return new PolicySerializer().GetPolicyFromJsonString(policyJson);
        }

        public Policy GetPolicyFromXMLString(string policyXml)
        {
            throw new System.NotImplementedException();
        }

        public string LoadPolicyFromFile()
        {
            return new FilePolicySource().GettPolicyFromSource();
        }

        public string LoadPolicyFromURI(string uri)
        {
            throw new System.NotImplementedException();
        }

        public void Log(string message)
        {
            new ConsoleLogger().Log(message);
        }

        public void UpdateRating(decimal rating)
        {
            throw new System.NotImplementedException();
        }
    }
}