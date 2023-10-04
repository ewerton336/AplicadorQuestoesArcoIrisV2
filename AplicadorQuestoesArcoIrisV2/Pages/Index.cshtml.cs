using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicadorQuestoesArcoIrisV2.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            // Verificar as credenciais do usuário
            if (UserName == "admin" && Password == "admin")
            {
                // Credenciais do administrador
                // Redirecione para a página de administrador
                return Redirect("/Questoes/Index");
            }
            else if (UserName == "aluno" && Password == "aluno")
            {
                // Credenciais do aluno
                // Redirecione para a página do aluno
                return Redirect("/Aluno/Index");
            }
            else
            {
                // Credenciais inválidas
                ModelState.AddModelError("", "Credenciais inválidas.");
                return Page();
            }
        }
    }
}
