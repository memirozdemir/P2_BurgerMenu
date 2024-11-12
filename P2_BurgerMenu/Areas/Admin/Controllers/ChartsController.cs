using P2_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace P2_BurgerMenu.Areas.Admin.Controllers
{
	public class ChartsController : Controller
	{
		BurgerMenuContext context = new BurgerMenuContext();
		public ActionResult Index()
		{
			var chart1Data = context.Products.ToList();
			var chart2Data = context.Reservations.ToList();
			var chart3Data = context.Products.ToList();
			var chart4Data = context.Products
	.Include(p => p.Category)
	.Where(p => p.Category != null) // Kategorisi olmayan ürünleri filtrele
	.GroupBy(p => p.Category.CategoryName)
	.Select(g => new
	{
		CategoryName = g.Key,
		ProductCount = g.Count()
	})
	.ToList();
			ViewBag.Chart1Data = chart1Data;
			ViewBag.Chart2Data = chart2Data;
			ViewBag.Chart3Data = chart3Data;
			ViewBag.Chart4Data = chart4Data;
			return View();
		}
	}
}