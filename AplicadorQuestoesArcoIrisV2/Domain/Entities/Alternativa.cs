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
        public bool AlternativaCorreta { get; set; }
        public int QuestaoId { get; set; }

        [ForeignKey(nameof(QuestaoId))]
        public Questao Questao { get; set; }


    }
}
