using NpsApi.Dominio;

namespace NpsApi.Repositorio.Interfaces
{
    public interface IRevisaoRepositorio
    {
        Task AdicionaRevisaoAsync(Revisao revisao);
        Task<List<Revisao>> BuscaTodasRevisoesAsync();
    }
}
