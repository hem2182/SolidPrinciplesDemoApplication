using System.IO;

namespace ArdalisRating_ISP_Applied
{
    public class FilePolicySource
    {
        public string GettPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}