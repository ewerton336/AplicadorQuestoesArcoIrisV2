using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplicadorQuestoesArcoIrisV2.Domain;
using AplicadorQuestoesArcoIrisV2.Domain.Entities;

namespace AplicadorQuestoesArcoIrisV2.Pages.Questoes
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Questao Questao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Questao == null)
            {
                return NotFound();
            }

            var questao = await _context.Questao.Include(x=>x.Alternativas).FirstOrDefaultAsync(m => m.Id == id);

            if (questao == null)
            {
                return NotFound();
            }
            else 
            {
                Questao = questao;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Questao == null)
            {
                return NotFound();
            }
            var questao = await _context.Questao.FindAsync(id);

            if (questao != null)
            {
                Questao = questao;
                var alternativas = await _context.Alternativas.Where(a => a.QuestaoId == Questao.Id).ToListAsync();

                if (alternativas.Any()) 
                _context.Alternativas.RemoveRange(alternativas);

                _context.Questao.Remove(Questao);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
