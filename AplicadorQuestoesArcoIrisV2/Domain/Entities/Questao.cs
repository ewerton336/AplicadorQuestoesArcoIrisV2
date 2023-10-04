using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AplicadorQuestoesArcoIrisV2.Domain.Entities
{
    public class Questao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Texto { get; set; }

        [DisplayName("Alternativas")]
        public ICollection<Alternativa> Alternativas { get; set; } = new List<Alternativa>();

        [NotMapped]
        public int AlternativaCorretaPosition { get; set; }
    }

}
