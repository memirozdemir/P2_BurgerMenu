using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
        public ActionResult CategoryProducts(int id)
        {
            var values = context.Products.Where(x=>x.CategoryID == id).ToList();
            return View(values);
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
		public ActionResult AddCategory(Category category)
		{
            context.Categories.Add(category);
            context.SaveChangesAsync();
			return RedirectToAction("CategoryList");
		}
		public ActionResult DeleteCategory(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
			context.SaveChanges();
			return RedirectToAction("CategoryList");
		}
        public ActionResult UpdateCategory(int id) 
        {
            var value = context.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value = context.Categories.Find(category.CategoryID);
            value.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
	}
}