using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        public ActionResult Details(int id)
        {
			var value = context.Abouts.Find(id);
			return View(value);
		}
        [HttpPost]
        public ActionResult Details(About about)
        {
            var values = context.Abouts.Find(about.AboutID);
            values.Title = about.Title;
            values.MiniContent = about.MiniContent;
            values.Content = about.Content;
            values.PictureURL = about.PictureURL;
            values.Address = about.Address;
            values.Phone = about.Phone;
            values.Mail = about.Mail;
            values.LocationURL = about.LocationURL;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}