using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallart.ViewModels.Users;
using Gallart.DataAccess;
using Gallart.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Gallart.ViewModels.Logged;

namespace Gallart.Controllers
{

    public class UsersController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            MyDbContext context = new MyDbContext();
            User item = new User();


            item.FirstName = model.FirstName;

            item.LastName = model.LastName;

            item.Email = model.Email;

            item.Username = model.Username;

            item.Password = model.Password;


            context.Users.Add(item);
            context.SaveChanges();

            if (this.HttpContext.Session.GetString("LoggedUserId") != null)
            {
                return RedirectToAction("Edit", "Logged");
            }
            User user = context.Users.Where(u => u.Username == item.Username && u.Password == item.Password).FirstOrDefault();

            if (user == null)
            {
                //errormessage
                ModelState.AddModelError("CreateUserFailed", "Something was wrong.Try again.");
                return RedirectToAction("Create", "Users");
            }
            HttpContext.Session.SetString("LoggedUserId", item.Id.ToString());
            HttpContext.Session.SetString("LoggedUsername", item.Username.ToString());

            return RedirectToAction("Edit", "Logged");
        }

        public IActionResult Delete(int id)
        {

            MyDbContext context = new MyDbContext();
            User item = context.Users.Where(u => u.Id == id).FirstOrDefault();
            List<List> list = context.Lists.Where(u => u.UserId == id).ToList();
            if (list != null)
            {
                foreach (List spisak in list)
                {
                    foreach (ListToPainting conn in context.ListToPaintings.Where(c => c.ListId == spisak.Id).ToList())
                    {
                        context.Remove(conn);
                    }
                    context.Remove(spisak);
                }
               
            }

            EntityEntry entry = context.Entry(item);

            this.HttpContext.Session.Remove("LoggedUserId");
            entry.State = EntityState.Deleted;


            context.SaveChanges();



            return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        public IActionResult Logout()
        {
            if (this.HttpContext.Session.GetString("LoggedUserId") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            this.HttpContext.Session.Remove("LoggedUserId");
            return RedirectToAction("Index", "Home");
        }


    }
}

