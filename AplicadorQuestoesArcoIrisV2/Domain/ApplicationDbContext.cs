using AplicadorQuestoesArcoIrisV2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AplicadorQuestoesArcoIrisV2.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Questao> Questao { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<RespostaAluno> Respostas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
