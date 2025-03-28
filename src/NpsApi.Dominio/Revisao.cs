using MongoDB.Bson.Serialization.Attributes;

namespace NpsApi.Dominio
{
    public class Revisao
    {
        [BsonId]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string NomeProduto { get; private set; }
        public int Score { get; private set; }
        public string? Comentario { get; private set; }
        public DateTime DataCriacao { get; private set; } = DateTime.UtcNow;

        public Revisao(string nomeProduto, int score, string? comentario = null)
        {
            this.ValidaRevisao(nomeProduto, score);

            NomeProduto = nomeProduto;
            Score = score;
            Comentario = comentario;
        }

        private void ValidaRevisao(string nomeProduto, int score)
        {
            if (score < 0 || score > 5) throw new ArgumentException("A pontuação deve estar entre 0 e 5.");

            if (string.IsNullOrEmpty(nomeProduto)) throw new ArgumentException("O nome do produto não pode ser nulo ou vazio.");
        }
    }
}