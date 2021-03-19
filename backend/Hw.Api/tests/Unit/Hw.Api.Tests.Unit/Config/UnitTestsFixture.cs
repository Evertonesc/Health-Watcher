using Hw.Api.Tests.Unit.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Hw.Api.Tests.Unit.Config
{
    public class UnitTestsFixture
    {
        public ServiceProvider ServiceProvider { get; set; }

        public UnitTestsFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IUnitTestConfiguration, UnitTestConfiguration>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
