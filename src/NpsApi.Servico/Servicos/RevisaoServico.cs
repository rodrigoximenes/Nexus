using NpsApi.Dominio;
using NpsApi.Repositorio.Interfaces;
using NpsApi.Servico.DTOs;

namespace NpsApi.Servico.Servicos
{
    public class RevisaoServico : IRevisaoServico
    {
        private readonly IRevisaoRepositorio _revisaoRepositorio;

        public RevisaoServico(IRevisaoRepositorio revisaoRepositorio)
        {
            _revisaoRepositorio = revisaoRepositorio;
        }

        public async Task AdicionaRevisaoAsync(string nomeProduto, int score, string? comentario)
        {
            var revisao = new Revisao(nomeProduto, score, comentario);
            await _revisaoRepositorio.AdicionaRevisaoAsync(revisao);
        }

        public async Task<RelatorioNpsDto> BuscaRelatorioNpsAsync()
        {
            var revisoes = await _revisaoRepositorio.BuscaTodasRevisoesAsync();
            var relatorio = RelatorioNps.Calcular(revisoes);
            return new RelatorioNpsDto(relatorio.Nps, relatorio.Promotores, relatorio.Detratores, relatorio.Total);
        }
    }
}
