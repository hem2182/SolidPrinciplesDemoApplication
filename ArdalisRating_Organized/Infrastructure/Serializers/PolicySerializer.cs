using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating_Organized
{
    public class PolicySerializer : IPolicySerializer
    {
        public Policy GetPolicyFromnString(string json)
        {
            return JsonConvert.DeserializeObject<Policy>(json,
                new StringEnumConverter());
        }
    }
}