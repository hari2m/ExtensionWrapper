using System;
using ExtensionWrapper.Interface;
using Microsoft.Extensions.Configuration;

namespace ExtensionWrapper.Impl
{
    public class ConfigurationWrapper : IConfigurationWrapper
    {
        private readonly IConfiguration _configuration;

        public ConfigurationWrapper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetValue(string key)
        {
            return _configuration["key"];
        }

        public string GetConnectionString(string key)
        {
            return _configuration.GetConnectionString("key");
        }
    }
}
