using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AplicadorQuestoesArcoIris.Domain.Entities
{
    public class RespostaAluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int PerguntaId { get; set; }
        public Questao Pergunta { get; set; }
        public int AlternativaEscolhidaId { get; set; }
        public Alternativa AlternativaEscolhida { get; set; }
    }
}
