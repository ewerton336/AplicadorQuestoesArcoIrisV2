
using AplicadorQuestoesArcoIrisV2.Domain;
using AplicadorQuestoesArcoIrisV2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicadorQuestoesArcoIrisV2.Pages.Questoes
{
    public class CadastrarQuestaoModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Questao Questao { get; set; } = new Questao(); // Inicialize Pergunta aqui

        public CadastrarQuestaoModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            int index = 0;
            foreach (var alternativa in Questao.Alternativas)
            {

                alternativa.Questao = Questao;
                alternativa.QuestaoId = Questao.Id;
                alternativa.AlternativaCorreta = index == Questao.AlternativaCorretaPosition;
                index++;
            }


            _context.Alternativas.AddRange(Questao.Alternativas);
            _context.SaveChanges();

            // Adicione a pergunta ao contexto do banco de dados
            _context.Questao.Update(Questao);
            _context.SaveChanges();

            // Limpe o modelo para permitir a inserção de uma nova pergunta
            ModelState.Clear();
            Questao = new Questao();

            // Redirecione para uma página de sucesso
            return RedirectToPage("/Questoes/Index");
        }
    }
}
