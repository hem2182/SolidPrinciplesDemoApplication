using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating_DIP_Applied
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromnString(string json);
    }
    public class PolicySerializer : IPolicySerializer
    {
        public Policy GetPolicyFromnString(string json)
        {
            return JsonConvert.DeserializeObject<Policy>(json,
                new StringEnumConverter());
        }
    }
}