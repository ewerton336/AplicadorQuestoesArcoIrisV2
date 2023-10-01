
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplicadorQuestoesArcoIrisV2.Domain.Entities;

namespace AplicadorQuestoesArcoIrisV2.Pages.Aluno
{
    public class IndexModel : PageModel
    {
        private readonly Domain.ApplicationDbContext _context;
        private IList<Domain.Entities.Aluno> aluno = default!;

        public IndexModel(Domain.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Domain.Entities.Aluno> Aluno { get => aluno; set => aluno = value; }
        public async Task OnGetAsync()
        {
            if (_context.Alunos != null)
            {
                Aluno = await _context.Alunos.ToListAsync();
            }
        }
    }
}
