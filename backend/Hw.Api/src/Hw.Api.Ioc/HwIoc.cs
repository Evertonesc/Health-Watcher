using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Hw.Api.Ioc
{
    public class HwIoc : IocConfiguration
    {
        public HwIoc(IServiceCollection services) : base(services) { }
        public override void RegisterDependecies() =>
            Database();


        void Database() =>
            _services.AddScoped(c => c.GetService<IMongoClient>().StartSession());
    }
}
