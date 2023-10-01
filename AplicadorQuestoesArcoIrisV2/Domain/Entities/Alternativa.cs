using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AplicadorQuestoesArcoIrisV2.Domain.Entities
{
    public class Alternativa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Correta { get; set; }
        public int PerguntaId { get; set; }
        public Questao Questao { get; set; }
    }
}
