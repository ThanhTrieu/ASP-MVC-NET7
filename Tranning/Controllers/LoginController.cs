using Microsoft.AspNetCore.Mvc;
using Tranning.Models;
using Tranning.Queries;

namespace Tranning.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        { 
            LoginModel model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            model = new LoginQueries().CheckLoginUser(model.Username, model.Password);
            if (string.IsNullOrEmpty(model.UserID) || string.IsNullOrEmpty(model.Username))
            {
                // dang nhap linh tinh - khong dung tai khoan trong database
                ViewData["MessageLogin"] = "Account invalid";
                return View(model);
            }
            // cho chuyen vao trang hom

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
