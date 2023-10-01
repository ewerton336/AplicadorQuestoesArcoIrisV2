using AplicadorQuestoesArcoIris.Domain;
using AplicadorQuestoesArcoIris.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicadorQuestoesArcoIrisV2.Pages.Questoes
{
    public class CadastrarquestaoModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Questao Pergunta { get; set; } = new Questao(); // Inicialize Pergunta aqui

        public CadastrarquestaoModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            foreach (var alternativa in Pergunta.Alternativas)
            {
                alternativa.Pergunta = Pergunta;
                alternativa.PerguntaId = Pergunta.Id;
            }
            Pergunta.Alternativas[Pergunta.AlternativaCorretaId].Correta = true;

            _context.Alternativas.AddRange(Pergunta.Alternativas);
            _context.SaveChanges();

            Pergunta.AlternativaCorretaId = Pergunta.Alternativas[Pergunta.AlternativaCorretaId].Id;

            // Adicione a pergunta ao contexto do banco de dados
            _context.Perguntas.Update(Pergunta);
            _context.SaveChanges();

            // Limpe o modelo para permitir a inserção de uma nova pergunta
            ModelState.Clear();
            Pergunta = new Questao();

            // Redirecione para uma página de sucesso
            return RedirectToPage("/Admin/Sucesso");
        }
    }
}
