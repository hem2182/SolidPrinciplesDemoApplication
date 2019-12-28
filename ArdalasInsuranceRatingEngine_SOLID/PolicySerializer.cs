using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalasInsuranceRatingEngine_SOLID
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