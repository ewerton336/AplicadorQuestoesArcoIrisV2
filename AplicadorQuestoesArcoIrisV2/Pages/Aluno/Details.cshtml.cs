using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AplicadorQuestoesArcoIrisV2.Pages.Aluno
{
    public class DetailsModel : PageModel
    {
        private readonly Domain.ApplicationDbContext _context;

        public DetailsModel(Domain.ApplicationDbContext context)
        {
            _context = context;
        }

      public Domain.Entities.Aluno Aluno { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Alunos == null)
            {
                return NotFound();
            }

            var aluno = await _context.Alunos.FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            else 
            {
                Aluno = aluno;
            }
            return Page();
        }
    }
}
