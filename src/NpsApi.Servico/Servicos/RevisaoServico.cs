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
            var total = revisoes.Count;
            if (total == 0) return new RelatorioNpsDto(0, 0, 0, 0);

            var promotores = revisoes.Count(r => r.Score >= 4);
            var detratores = revisoes.Count(r => r.Score <= 2);

            var nps = ((double)(promotores - detratores) / total) * 100;
            return new RelatorioNpsDto(nps, promotores, detratores, total);
        }
    }
}
