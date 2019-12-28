using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_ISP
{
    public interface IRatingContext
    {
        void Log(string message);
        string LoadPolicyFromFile();
        string LoadPolicyFromURI(string uri);
        Policy GetPolicyFromJsonString(string policyJson);
        Policy GetPolicyFromXMLString(string policyXml);
        Rater CreateRaterForPolicy(Policy policy, IRatingContext context);
        void UpdateRating(decimal rating);
        RatingEngine Engine { get; set; }
        ConsoleLogger Logger { get; }
    }
}
