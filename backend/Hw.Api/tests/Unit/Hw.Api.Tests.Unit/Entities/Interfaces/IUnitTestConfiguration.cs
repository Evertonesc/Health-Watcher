using Microsoft.Extensions.Configuration;

namespace Hw.Api.Tests.Unit.Entities.Interfaces
{
    public interface IUnitTestConfiguration
    {
        IConfiguration GetConfig();
    }
}
