namespace ExtensionWrapper.Interface
{
    public interface IConfigurationWrapper
    {
        string GetValue(string key);
        string GetConnectionString(string key);
    }
}
