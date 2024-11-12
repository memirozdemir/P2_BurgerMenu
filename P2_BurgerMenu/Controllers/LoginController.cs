using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace P2_BurgerMenu.Controllers
{
    public class LoginController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);

            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["x"]=values.Username.ToString();
                return RedirectToAction("Index","Dashboard",new { area= "Admin"});
                }
            else
            {
                return View();
            }
        }
    }
}