using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("[Controller]")]
    public class LoginController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public async Task<IActionResult> Post(NovoUsuarioViewModel usuario)
        {
            bool podeLogar = await _usuarioService.Autenticar(usuario);

            if (!podeLogar)
            {
                BadRequest("Login inválido");
            }

            return base.RedirectToAction("Index", "Home");
        }
    }
}
