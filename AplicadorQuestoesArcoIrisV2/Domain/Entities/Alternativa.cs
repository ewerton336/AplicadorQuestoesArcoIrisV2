namespace AplicadorQuestoesArcoIris.Domain.Entities
{
    public class Alternativa
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Correta { get; set; }
        public int PerguntaId { get; set; }
        public Pergunta Pergunta { get; set; }
    }
}
