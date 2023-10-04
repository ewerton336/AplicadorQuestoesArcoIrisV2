using AplicadorQuestoesArcoIrisV2.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AplicadorQuestoesArcoIrisV2.Pages.Questoes
{
    public class IndexModel : PageModel
    {
        private readonly AplicadorQuestoesArcoIrisV2.Domain.ApplicationDbContext _context;

        public IndexModel(AplicadorQuestoesArcoIrisV2.Domain.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Questao> Questao { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Questao != null)
            {
                Questao = await _context.Questao.Include(q => q.Alternativas).ToListAsync();
            }
        }
    }
}
