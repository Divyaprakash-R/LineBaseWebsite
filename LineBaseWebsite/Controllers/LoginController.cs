using LineBaseWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LineBaseWebsite.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            var Users = new List<string>()
            {
                "Operator",
                "Superviser"
            };
            TempData["Users"] = Users;
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (login.User == "Superviser" && login.LineNumber == "Operator" && login.Password == "hi")
            {
                RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "User details is wrong";
            }
            return View();
        }
    }
}