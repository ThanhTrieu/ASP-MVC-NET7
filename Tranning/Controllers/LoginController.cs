using Microsoft.AspNetCore.Mvc;

namespace Tranning.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
