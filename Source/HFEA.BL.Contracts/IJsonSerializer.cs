namespace HFEA.BL.Contracts
{
    public interface IJsonSerializer
    {
        T Deserialize<T>(string s, bool includeObjectType = false);
        string Serialize<T>(T obj, bool includeObjectType = false);
    }
}