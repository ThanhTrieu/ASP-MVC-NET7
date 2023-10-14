using Microsoft.AspNetCore.Mvc;
using Tranning.Models;

namespace Tranning.Controllers
{
    public class ContactController : Controller
    {
        static IList<Students> studentList = new List<Students> { 
            new Students() {StudentId = 1, StudentName = "Teo", StudentAge = 21},
            new Students() {StudentId = 2, StudentName = "Ty", StudentAge = 20},
            new Students() {StudentId = 3, StudentName = "Hoi", StudentAge = 22},
            new Students() {StudentId = 4, StudentName = "Suu", StudentAge = 19},
            new Students() {StudentId = 5, StudentName = "Dan", StudentAge = 20},
        };

        public IActionResult Index()
        {
            return View(studentList);
        }

        public IActionResult Money(int id, string name, string email)
        {
            // id va name: tham so truyen vao tu ben ngoai ung dung
            //return "Cha xu nao : " + id + " name : " + name + " email: " + email;
            // https:4700/Contact/Money?id=10&name=test&email=test@gmail.com

            // truyen cac bien ra ngoai view
            ViewData["id"] = id;
            ViewData["name"] = name;
            ViewData["email"] = email;

            return View();// hien thi giao dien
        }
    }
}
