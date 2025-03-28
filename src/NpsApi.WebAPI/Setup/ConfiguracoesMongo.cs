using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NpsApi.Repositorio;

namespace NpsApi.WebAPI.Setup
{
    public static class ConfiguracoesMongo
    {
        public static IServiceCollection AddConfiguracoesMongo(this IServiceCollection servicos)
        {

            servicos.AddSingleton<IMongoClient>(serviceProvider =>
            {
                var mongoSettings = serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value;
                return new MongoClient(mongoSettings.ConnectionString);
            });

            servicos.AddSingleton<IMongoDatabase>(serviceProvider =>
            {
                var mongoSettings = serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value;
                var client = serviceProvider.GetRequiredService<IMongoClient>();
                return client.GetDatabase(mongoSettings.DatabaseName);
            });

            servicos.AddSingleton<MongoDbContext>();

            return servicos;
        }
    }
}