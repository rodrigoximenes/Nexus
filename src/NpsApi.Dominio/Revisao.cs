namespace NpsApi.Dominio
{
    public class Revisao
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string NomeProduto { get; private set; }
        public int Score { get; private set; }
        public string? Comentario { get; private set; }
        public DateTime DataCriacao { get; private set; } = DateTime.UtcNow;

        public Revisao(string nomeProduto, int score, string? comentario = null)
        {
            if (score < 0 || score > 5)
                throw new ArgumentException("A pontuação deve estar entre 0 e 5.");

            NomeProduto = nomeProduto;
            Score = score;
            Comentario = comentario;
        }
    }
}