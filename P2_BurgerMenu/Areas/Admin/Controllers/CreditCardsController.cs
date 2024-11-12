using P2_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    public class CreditCardsController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            var values = context.CreditCards.ToList();
            return View(values);
        }
    }
}