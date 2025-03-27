using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using NpsApi.Dominio;

namespace NpsApi.Repositorio
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IMongoDatabase database)
        {
            _database = database;
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));
        }

        public IMongoCollection<Revisao> BuscaTodasRevisoes()
        {
            return _database.GetCollection<Revisao>("Revisao");
        }
    }
}
