using AplicadorQuestoesArcoIris.Domain;
using AplicadorQuestoesArcoIris.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AplicadorQuestoesArcoIrisV2.Pages.Questoes
{
    public class ListarQuestoesModel : PageModel
    {
        private readonly ApplicationDbContext _context; // Substitua pelo seu contexto de banco de dados

        public ListarQuestoesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Pergunta> Questoes { get; set; }

        public void OnGet()
        {
            Questoes = _context.Perguntas.Include(p => p.Alternativas).ToList();
        }
    }
}
