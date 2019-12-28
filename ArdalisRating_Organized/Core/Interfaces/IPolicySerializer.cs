namespace ArdalisRating_Organized
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromnString(string json);
    }
}