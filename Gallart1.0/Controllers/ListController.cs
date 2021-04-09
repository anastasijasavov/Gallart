using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallart.Entities;
using Gallart.ViewModels.Logged;
using Gallart.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Gallart.Controllers
{
    public class ListController : Controller
    {

        public IActionResult MyLists()
        {
            ExploreVM model = new ExploreVM();
            MyDbContext context = new MyDbContext();
            int loggedUser = Convert.ToInt32(HttpContext.Session.GetString("LoggedUserId"));
            List<List> listOfLists = context.Lists.Where(m => m.UserId == loggedUser).ToList();
            model.ListOfLists = listOfLists;

            return View(model);
        }
        [HttpGet]
        public IActionResult MyLists(int id)
        {
            ExploreVM model = new ExploreVM();
            MyDbContext context = new MyDbContext();
            int loggedUser = Convert.ToInt32(HttpContext.Session.GetString("LoggedUserId"));
            List<List> listOfLists = context.Lists.Where(m => m.UserId == loggedUser).ToList();
            model.ListOfLists = listOfLists;
            model.List = new List();
            model.List.Id = id;
            ViewBag.id = id;
            
            return View(model);
        }


        [HttpPost]
        public IActionResult MyLists(ExploreVM model)
        {

            if (this.HttpContext.Session.GetString("LoggedUserId") == null)
                return RedirectToAction("Login", "Home");

            // MyDbContext context = new MyDbContext();
            // List<List> listOfLists = (List<List>)context.Lists.Where(m => m. == HttpContext.Session.GetString("LoggedUserId").FirstOrDefault());

            // List lists =context.Lists.Where(m => m.ParentUser.ToString() == HttpContext.Session.GetString("LoggedUserId")).FirstOrDefault();
            
            // model.ListOfLists = context.Lists.Where(u => u.UserId == HttpContext.Session.GetString("LoggedUserId").FirstOrDefault()).ToList();
            return View(model);
        }

        public IActionResult Paintings(ExploreVM model)
        {

            MyDbContext context = new MyDbContext();
            model.Paintings = context.Paintings.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Paintings(int id)
        {
            ExploreVM model = new ExploreVM();
            MyDbContext context = new MyDbContext();

            model.List = context.Lists.Where(c => c.Id == id).FirstOrDefault();
            if (model.List == null)
            {
                RedirectToAction("MyLists", "List");
            }

            List<ListToPainting> listTP = context.ListToPaintings.Where(m => m.ListId == model.List.Id).ToList();

            if (listTP == null)
            {
                RedirectToAction("MyLists", "List");
            }
            List<Painting> paintings = new List<Painting>();

            foreach (Painting painting in context.Paintings.ToList())
            {
                foreach (ListToPainting connection in listTP)
                {
                    if (painting.Id == connection.PaintingId)
                    {
                        paintings.Add(painting);

                    }
                }


            }
            model.Paintings = paintings;

            return View(model);
        }



        public IActionResult AddToThisList(int paintingId, int listId)
        {
            ExploreVM model = new ExploreVM();
            MyDbContext ctx = new MyDbContext();
            Painting painting = new Painting();
            List list = new List();


            //trazi sliku ciji smo id dobili u inputu u explore.cshtml
            painting = ctx.Paintings.Where(p => p.Id == paintingId).FirstOrDefault();
            list = ctx.Lists.Where(p => p.Id == listId).FirstOrDefault();
            ListToPainting listTP = new ListToPainting();

            listTP.PaintingId = painting.Id;
            listTP.ListId = list.Id;
            ctx.ListToPaintings.Add(listTP);
            ctx.SaveChanges();

            return RedirectToAction("Explore", "Logged");
        }
        //radi
        [HttpPost]
        public IActionResult MakeNewList(ExploreVM model)
        {
            MyDbContext context = new MyDbContext();
            List list = new List();
            list.Name = model.List.Name;
            if (list.Name!=null)
            {
                list.UserId = Convert.ToInt32(HttpContext.Session.GetString("LoggedUserId"));
                list.isDeleted = false;

                context.Lists.Add(list);
                context.SaveChanges();
                return RedirectToAction("MyLists", "List");
            }
            else
            {
                return RedirectToAction("MyLists", "List");
            }
           
        }

        public IActionResult Painting(ExploreVM model)
        {

            MyDbContext context = new MyDbContext();
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Explore", "Logged");
            }
            Painting painting = context.Paintings.Where(u => u.Id == model.Painting.Id).FirstOrDefault();

            if (painting == null)
            {
                return RedirectToAction("Explore", "Logged");
            }
            model.Painting = painting;

            return View(model);
        }

        [HttpGet]
        public IActionResult Painting(int id)
        {
            MyDbContext context = new MyDbContext();
            Painting painting = context.Paintings.Where(u => u.Id == id).FirstOrDefault();
            ExploreVM model = new ExploreVM();
            if (painting == null)
            {
                return RedirectToAction("Explore", "Logged");
            }
            model.Painting = painting;
            model.Painting.Id = painting.Id;
            model.Painting.Path = painting.Path;
            model.Painting.Name = painting.Name;
            model.Painting.Artist = painting.Artist;
            model.Painting.Genre = painting.Genre;
            model.Painting.Year = painting.Year;
            return View(model);
        }

        [HttpGet]
        public IActionResult RemoveFromList(int id)
        {
            MyDbContext context = new MyDbContext();
            ListToPainting listTP = new ListToPainting();
            listTP = context.ListToPaintings.Where(c => c.PaintingId == id).FirstOrDefault();

            context.ListToPaintings.Remove(listTP);
            context.SaveChanges();
            return RedirectToAction("Paintings", "List", new { id = listTP.ListId });
        }
        public IActionResult Rename(int id)
        {
            MyDbContext context = new MyDbContext();
            ExploreVM model = new ExploreVM();
            List list = context.Lists.Where(i => i.Id == id).FirstOrDefault();
            model.List = list;
            model.List.Id = list.Id;
            model.List.Name = list.Name;          
            model.List.UserId = list.UserId;
            model.List.isDeleted = list.isDeleted;
            ViewBag.ListId = model.List.Id;
            return RedirectToAction("MyLists", "List", new { id=list.Id });
        }
        [HttpPost]
        public IActionResult Rename(ExploreVM model)
        {
           
            MyDbContext context = new MyDbContext();
            List list = context.Lists.Where(i => i.Id ==model.List.Id).FirstOrDefault();
            if (model.List.Name!=null)
            {
                list.Name = model.List.Name;

                context.Lists.Update(list);
                context.SaveChanges();
                return RedirectToAction("MyLists", "List");
            }
            else
            {
                return RedirectToAction("MyLists", "List");
            }
           
        }


        public IActionResult DeleteList(int id)
        {
            MyDbContext context = new MyDbContext();
            ExploreVM model = new ExploreVM();
            List<ListToPainting> connections = context.ListToPaintings.Where(u => u.ListId == id).ToList();
            List list = context.Lists.Where(u => u.Id == id).FirstOrDefault();
            foreach (ListToPainting item in connections)
            {
                context.Remove(item);
            }
            context.Remove(list);
            context.SaveChanges();
            return RedirectToAction("MyLists", "List");
        }
    }
}
