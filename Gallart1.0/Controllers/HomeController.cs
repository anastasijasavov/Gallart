using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallart.ViewModels.Home;
using Gallart.ViewModels.Users;
using Gallart.DataAccess;
using Gallart.Entities;
using Microsoft.AspNetCore.Http;

namespace Gallart1._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {

            if (this.HttpContext.Session.GetString("LoggedUserId") != null)
            {
                return RedirectToAction("Edit", "Logged");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (this.HttpContext.Session.GetString("LoggedUserId") != null)
            {
                return RedirectToAction("Edit", "Logged");
            }
            /*ovde treba da se pretrazi iz baze*/
            MyDbContext context = new MyDbContext();
            User user = context.Users.Where(u => u.Username == model.Username && u.Password == model.Password).FirstOrDefault();
            if (user == null)
            {
                //errormessage
                ModelState.AddModelError("AuthenticationFailed", "Wrong username and/or password");
                return RedirectToAction("Login", "Home");
            }

            this.HttpContext.Session.SetString("LoggedUserId", user.Id.ToString());
            this.HttpContext.Session.SetString("LoggedUserUsername", user.Username);
            return RedirectToAction("Edit", "Logged");





        }

    }
}
