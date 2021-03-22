using Microsoft.Extensions.DependencyInjection;

namespace Hw.Api.Ioc
{
    public abstract class IocConfiguration
    {
        protected IServiceCollection _services;

        public IocConfiguration(IServiceCollection services)
        {
            _services = services;
            RegisterDependecies();
        }
        public abstract void RegisterDependecies();
    }
}
