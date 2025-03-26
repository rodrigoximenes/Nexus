using Microsoft.AspNetCore.Mvc;
using NpsApi.Servico.DTOs;
using NpsApi.Servico.Servicos;

namespace NpsApi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevisaoController : ControllerBase
    {
        private readonly RevisaoServico _revisaoServico;

        public RevisaoController(RevisaoServico revisaoServico)
        {
            _revisaoServico = revisaoServico;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RevisaoDto dto)
        {
            await _revisaoServico.AdicionaRevisaoAsync(dto.NomeProduto, dto.Score, dto.Comentario);
            return Ok(new { Message = "Revisão cadastrada com sucesso!" });
        }

        [HttpGet("nps")]
        public async Task<IActionResult> BuscaRelatorioNps()
        {
            var report = await _revisaoServico.BuscaRelatorioNpsAsync();
            return Ok(report);
        }
    }
}