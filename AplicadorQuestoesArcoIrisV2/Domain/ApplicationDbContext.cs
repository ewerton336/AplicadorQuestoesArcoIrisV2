using AplicadorQuestoesArcoIris.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AplicadorQuestoesArcoIris.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
    }
}
