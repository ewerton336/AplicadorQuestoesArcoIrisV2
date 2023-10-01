using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicadorQuestoesArcoIrisV2.Pages.Aluno
{
    public class CreateModel : PageModel
    {
        private readonly Domain.ApplicationDbContext _context;

        public CreateModel(Domain.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Domain.Entities.Aluno Aluno { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Alunos == null || Aluno == null)
            {
                return Page();
            }

            _context.Alunos.Add(Aluno);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
