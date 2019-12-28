using System.IO;

namespace ArdalasInsuranceRatingEngine_SOLID
{
    public class FilePolicySource
    {
        public string GettPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}