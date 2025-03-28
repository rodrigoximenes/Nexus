using MongoDB.Driver;
using NpsApi.Dominio;
using NpsApi.Repositorio.Interfaces;

namespace NpsApi.Repositorio
{
    public class RevisaoRepositorio : IRevisaoRepositorio
    {
        private readonly MongoDbContext _contexto;
        public RevisaoRepositorio(MongoDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task AdicionaRevisaoAsync(Revisao revisao)
        {
            var colecao = _contexto.BuscaTodasRevisoes();  
            await colecao.InsertOneAsync(revisao);
        }

        public async Task<List<Revisao>> BuscaTodasRevisoesAsync()
        {
            var colecao = _contexto.BuscaTodasRevisoes();
            return await colecao.Find(FilterDefinition<Revisao>.Empty).ToListAsync();
        }
    }
}
