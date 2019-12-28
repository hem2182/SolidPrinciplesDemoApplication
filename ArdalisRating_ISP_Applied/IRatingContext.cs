using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_ISP_Applied
{
    public interface IRatingUpdator
    {
        void UpdateRating(decimal rating);
    }
    public interface IRatingContext : ILogger
    {
        string LoadPolicyFromFile();
        string LoadPolicyFromURI(string uri);
        Policy GetPolicyFromJsonString(string policyJson);
        Policy GetPolicyFromXMLString(string policyXml);
        Rater CreateRaterForPolicy(Policy policy, IRatingContext context);
        RatingEngine Engine { get; set; }
    }
}
