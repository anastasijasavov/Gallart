using Gallart.DataAccess;
using Gallart.Entities;
using Gallart.ViewModels.Logged;
using Gallart.ViewModels.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallart.Controllers
{
    public class LoggedController : Controller
    {

        //to se pojavljuje odmah nakon nekog redirecta na ovu akciju jer je get zahtev po defaultu valjda
        [HttpGet]
        public IActionResult Edit()
        {
            //ako ne postoji iz sesije user onda nista vrati me na login
            if (this.HttpContext.Session.GetString("LoggedUserId") == null)
                return RedirectToAction("Login", "Home");


            MyDbContext context = new MyDbContext();
            //nadji korisnika koji ima taj id iz sesije
            User user = context.Users.Where(u => u.Id.ToString() == HttpContext.Session.GetString("LoggedUserId")).FirstOrDefault();
            //ako ne postoji redirect na login jer je doslo do greske
            if (user == null)
            {
                return RedirectToAction("Login", "Home");
            }

            //u model stavi sve podatke da bi izbacilo sve podatke u my account, tj edit strancu-view
            EditVM model = new EditVM();
            model.Id = user.Id;
            model.Username = user.Username;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Email = user.Email;
            model.Password = user.Password;
            //najvaznije je da se vrati izgled sa parametrom model da bi vratilo podatke u edit , ovo se sve desava za manje od sekunde 
            return View(model);
        }
        //nakon edit sa get zahtevom odlazi se na edit sa modelom i uzimaju se podaci
        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            MyDbContext context = new MyDbContext();

            //da se uporedi iz sesije da li je ID jednak nekom ID -ju iz baze
            User user = context.Users.Where(u => u.Id.ToString() == HttpContext.Session.GetString("LoggedUserId")).FirstOrDefault();

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            user.Id = model.Id;
            user.Username = model.Username;
            user.Email = model.Email;
            user.Password = model.Password;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;

            context.Users.Update(user);
            context.SaveChanges();
            //vracaju se podaci
            return RedirectToAction("Explore", "Logged");
        }

        public IActionResult Explore(ExploreVM model)
        {
            MyDbContext context = new MyDbContext();

            List<Painting> paintings = context.Paintings.ToList();

            model.Paintings = paintings;
            model.ListOfLists = context.Lists.Where(c=>c.UserId==Convert.ToInt32(HttpContext.Session.GetString("LoggedUserId"))).ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Explore()
        {
            ExploreVM model = new ExploreVM();
            MyDbContext context = new MyDbContext();

            model.Paintings = context.Paintings.ToList();
            model.ListOfLists = context.Lists.Where(c => c.UserId == Convert.ToInt32(HttpContext.Session.GetString("LoggedUserId"))).ToList();

            return View(model);
        }

    }
}
