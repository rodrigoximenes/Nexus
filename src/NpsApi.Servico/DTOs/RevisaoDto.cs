using System.ComponentModel.DataAnnotations;

namespace NpsApi.Servico.DTOs
{
    public record RevisaoDto
    {
        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres.")]
        public string NomeProduto { get; init; } = string.Empty;

        [Range(0, 5, ErrorMessage = "O score deve estar entre 0 e 5.")]
        public int Score { get; init; }

        [StringLength(500, ErrorMessage = "O comentário deve ter no máximo 500 caracteres.")]
        public string? Comentario { get; init; }
    }
}
