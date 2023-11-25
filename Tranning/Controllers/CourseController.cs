using Microsoft.AspNetCore.Mvc;

namespace Tranning.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
