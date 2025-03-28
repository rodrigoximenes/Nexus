using NpsApi.Servico.DTOs;

namespace NpsApi.Servico.Servicos
{
    public interface IRevisaoServico
    {
        Task AdicionaRevisaoAsync(string nomeProduto, int score, string? comentario);
        Task<RelatorioNpsDto> BuscaRelatorioNpsAsync();
    }
}
