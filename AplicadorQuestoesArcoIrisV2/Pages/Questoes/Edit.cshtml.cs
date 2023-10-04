using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplicadorQuestoesArcoIrisV2.Domain;
using AplicadorQuestoesArcoIrisV2.Domain.Entities;

namespace AplicadorQuestoesArcoIrisV2.Pages.Questoes
{
    public class EditModel : PageModel
    {
        private readonly AplicadorQuestoesArcoIrisV2.Domain.ApplicationDbContext _context;

        public EditModel(AplicadorQuestoesArcoIrisV2.Domain.ApplicationDbContext context)
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

            var questao =  await _context.Questao.FirstOrDefaultAsync(m => m.Id == id);
            if (questao == null)
            {
                return NotFound();
            }
            Questao = questao;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Questao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestaoExists(Questao.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QuestaoExists(int id)
        {
          return (_context.Questao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
