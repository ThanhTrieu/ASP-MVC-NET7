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
            // luu thong tin cua nguoi dung vao session
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUserID")))
            {
                HttpContext.Session.SetString("SessionUserID",model.UserID);
                HttpContext.Session.SetString("SessionRoleID", model.RoleID);
                HttpContext.Session.SetString("SessionUsername", model.Username);
                HttpContext.Session.SetString("SessionEmail", model.EmailUser);

            }
            // cho chuyen vao trang home
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUserID")))
            {
                // xoa cac session da dc tao ra
                HttpContext.Session.Remove("SessionUserID");
                HttpContext.Session.Remove("SessionRoleID");
                HttpContext.Session.Remove("SessionUsername");
                HttpContext.Session.Remove("SessionEmail");
            }
            return RedirectToAction(nameof(LoginController.Index), "Login");
        }
    }
}
