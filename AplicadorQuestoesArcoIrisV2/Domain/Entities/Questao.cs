using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AplicadorQuestoesArcoIrisV2.Domain.Entities
{
    public class Questao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Texto { get; set; }
        public List<Alternativa> Alternativas { get; set; }
        public int AlternativaCorretaId { get; set; }
        public string TextoRespostaCorreta => Alternativas.FirstOrDefault(a => a.Id == AlternativaCorretaId)?.Texto;
    }

}
