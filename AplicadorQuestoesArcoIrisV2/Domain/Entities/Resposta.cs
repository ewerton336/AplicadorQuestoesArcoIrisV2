namespace AplicadorQuestoesArcoIris.Domain.Entities
{
    public class Resposta
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int PerguntaId { get; set; }
        public Pergunta Pergunta { get; set; }
        public int AlternativaEscolhidaId { get; set; }
        public Alternativa AlternativaEscolhida { get; set; }
    }
}
