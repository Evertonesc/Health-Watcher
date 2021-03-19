using Hw.Api.Tests.Unit.Entities.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Hw.Api.Tests.Unit.Config
{
    public class UnitTestConfiguration : IUnitTestConfiguration
    {
        public IConfiguration GetConfig() =>

            new ConfigurationBuilder()
                .AddJsonFile("appsettings.Tests.json", optional: false, reloadOnChange: true)
                .Build();
    }
}
