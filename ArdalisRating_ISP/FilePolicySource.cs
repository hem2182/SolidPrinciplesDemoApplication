using System.IO;

namespace ArdalisRating_ISP
{
    public class FilePolicySource
    {
        public string GettPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}