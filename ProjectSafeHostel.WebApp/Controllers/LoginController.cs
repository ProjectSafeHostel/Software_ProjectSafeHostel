using Microsoft.AspNetCore.Mvc;

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
