using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        // GET: Admin/Profile
        public ActionResult MyProfileList()
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x=>x.Username == userName).FirstOrDefault();

            return View(values);
        }
        [HttpPost]
        public ActionResult MyProfileList(P2_BurgerMenu.Entities.Admin admin)
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x => x.Username == userName).FirstOrDefault();
            values.Username = admin.Username;
            values.Surname = admin.Surname;
            values.Name = admin.Name;
            values.Password = admin.Password;
            values.Email = admin.Email;
            context.SaveChanges();
            return RedirectToAction("Index","Login");

        }
    }
}