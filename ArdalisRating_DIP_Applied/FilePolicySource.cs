using System.IO;

namespace ArdalisRating_DIP_Applied
{
    public interface IPolicySource
    {
        string GetPolicyFromSource();
    }
    public class FilePolicySource : IPolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}