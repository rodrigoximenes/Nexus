using FluentAssertions;

namespace NpsApi.Dominio.Tests
{
    public class RelatorioNpsTests
    {
        [Theory]
        [InlineData(new int[] { 5, 4, 2, 1 }, 0, 2, 2, 4)]  // Caso base do primeiro teste
        [InlineData(new int[] { 5, 5, 5, 5 }, 100, 4, 0, 4)] // Apenas promotores
        [InlineData(new int[] { 1, 1, 2, 2 }, -100, 0, 4, 4)] // Apenas detratores
        [InlineData(new int[] { 3, 3, 3, 3 }, 0, 0, 0, 4)]   // Apenas neutros
        [InlineData(new int[] { }, 0, 0, 0, 0)]              // Lista vazia

        public void Calcular_DeveRetornarNpsCorreto(int[] scores, double npsEsperado, int promotoresEsperado, int detratoresEsperado, int totalEsperado)
        {
            // Arrange
            var revisoes = new List<Revisao>();
            foreach (var score in scores)
            {
                revisoes.Add(new Revisao("Produto Teste", score, "Comentário"));
            }

            // Act
            var resultado = RelatorioNps.Calcular(revisoes);

            // Assert
            resultado.Nps.Should().Be(npsEsperado);
            resultado.Promotores.Should().Be(promotoresEsperado);
            resultado.Detratores.Should().Be(detratoresEsperado);
            resultado.Total.Should().Be(totalEsperado);
        }
    }
}
