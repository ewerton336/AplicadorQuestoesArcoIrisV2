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
    public class DetailsModel : PageModel
    {
        private readonly AplicadorQuestoesArcoIrisV2.Domain.ApplicationDbContext _context;

        public DetailsModel(AplicadorQuestoesArcoIrisV2.Domain.ApplicationDbContext context)
        {
            _context = context;
        }

      public Questao Questao { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Questao == null)
            {
                return NotFound();
            }

            var questao = await _context.Questao.FirstOrDefaultAsync(m => m.Id == id);
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
    }
}
