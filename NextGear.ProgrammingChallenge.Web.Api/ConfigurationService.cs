using Microsoft.Extensions.Configuration;
using NextGear.ProgrammingChallenge.Core;

namespace NextGear.ProgrammingChallenge.Web.Api
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _configuration;

        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string DeviceFilesPath => _configuration["filePaths"];
    }
}