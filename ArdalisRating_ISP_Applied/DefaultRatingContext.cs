namespace ArdalisRating_ISP_Applied
{
    internal class DefaultRatingContext : IRatingContext
    {
        public RatingEngine Engine { get; set; }

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
    }
}