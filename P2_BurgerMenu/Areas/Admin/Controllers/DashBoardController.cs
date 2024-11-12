using P2_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
			var values = context.Products
								.OrderByDescending(x => x.ProductSold)
								.ToList();
			return View(values);
		}
    }
}