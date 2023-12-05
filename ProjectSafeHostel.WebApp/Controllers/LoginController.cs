using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.ViewModels;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("[Controller]")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
