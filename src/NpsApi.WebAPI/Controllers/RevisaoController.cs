using Microsoft.AspNetCore.Mvc;
using NpsApi.Servico.DTOs;
using NpsApi.Servico.Servicos;

namespace NpsApi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevisaoController : ControllerBase
    {
        private readonly IRevisaoServico _revisaoServico;

        public RevisaoController(IRevisaoServico revisaoServico)
        {
            _revisaoServico = revisaoServico;
        }

        /// <summary>
        /// Cadastra uma nova revisão de produto.
        /// </summary>
        /// <param name="dto">Objeto de revisão contendo os detalhes do produto.</param>
        /// <returns>Mensagem de sucesso ou erro.</returns>
        /// <response code="200">Revisão cadastrada com sucesso.</response>
        /// <response code="400">Se houver erros de validação nos dados fornecidos.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] RevisaoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _revisaoServico.AdicionaRevisaoAsync(dto.NomeProduto, dto.Score, dto.Comentario);
                return Ok(new { Mensagem = "Revisão cadastrada com sucesso!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = "Ocorreu um erro ao cadastrar a revisão.", Detalhes = ex.Message });
            }
        }

        /// <summary>
        /// Busca o relatório NPS com base nas revisões cadastradas.
        /// </summary>
        /// <returns>Relatório NPS calculado.</returns>
        /// <response code="200">Relatório NPS retornado com sucesso.</response>
        [HttpGet("nps")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> BuscaRelatorioNps()
        {
            try
            {
                var relatorio = await _revisaoServico.BuscaRelatorioNpsAsync();
                return Ok(relatorio);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = "Ocorreu um erro ao buscar o relatório NPS.", Detalhes = ex.Message });
            }
        }
    }
}