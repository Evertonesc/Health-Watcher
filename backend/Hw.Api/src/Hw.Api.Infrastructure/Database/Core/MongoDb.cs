using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Hw.Api.Infrastructure.Database.Core
{
    public static class MongoDb
    {
        public static void ConnectMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoConnectionString = configuration.GetSection("MongoDb:ConnectionString").Value;
            services.AddSingleton<IMongoClient>(new MongoClient(mongoConnectionString));
        }
    }
}
