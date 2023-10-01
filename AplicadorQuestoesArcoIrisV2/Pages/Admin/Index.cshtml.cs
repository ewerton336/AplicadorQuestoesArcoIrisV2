using AplicadorQuestoesArcoIris.Domain;
using AplicadorQuestoesArcoIris.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicadorQuestoesArcoIrisV2.Pages.Admin
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _context; // Injete o DbContext para interagir com o banco de dados

        [BindProperty]
        public Pergunta Pergunta { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Adicione a pergunta ao contexto do banco de dados
                _context.Perguntas.Add(Pergunta);
                _context.SaveChanges();

                // Limpe o modelo para permitir a inserção de uma nova pergunta
                ModelState.Clear();
                Pergunta = new Pergunta();

                // Redirecione para uma página de sucesso ou para a lista de perguntas
                return RedirectToPage("/Admin/Sucesso");
            }

            return Page();
        }

    }
}
