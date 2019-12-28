using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating_ISP_Applied
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJsonString(string json)
        {
            return JsonConvert.DeserializeObject<Policy>(json,
                new StringEnumConverter());
        }
    }
}