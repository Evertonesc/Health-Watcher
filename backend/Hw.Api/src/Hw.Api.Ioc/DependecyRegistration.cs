using Microsoft.Extensions.DependencyInjection;

namespace Hw.Api.Ioc
{
    public static class DependecyRegistration
    {
        public static void DependecyManager(this IServiceCollection services)
        {
            _ = new HwIoc(services);
        }
    }
}
