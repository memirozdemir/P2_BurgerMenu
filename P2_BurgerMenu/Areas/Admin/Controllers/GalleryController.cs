using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
	public class GalleryController : Controller
	{
		BurgerMenuContext context = new BurgerMenuContext();
		public ActionResult Index()
		{
			var values = context.Galleries.ToList();
			return View(values);
		}
		public ActionResult Edit(int id)
		{
			var values = context.Galleries.Find(id);
			return View(values);
		}
		[HttpPost]
		public ActionResult Edit(Gallery gallery)
		{
			var values = context.Galleries.Find(gallery.GalleryID);
			values.PictureURL = gallery.PictureURL;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult AddPicture()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddPicture(Gallery gallery)
		{
			context.Galleries.Add(gallery);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult Delete(int id)
		{
			context.Galleries.Remove(context.Galleries.Find(id));
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}