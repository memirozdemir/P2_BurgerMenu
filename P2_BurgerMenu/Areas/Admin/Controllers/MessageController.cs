using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Inbox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.ReceiverMail == email).ToList();
            return View(values);
        }
        public ActionResult Sendbox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x=>x.Username ==userName).Select(y=>y.Email).FirstOrDefault();
            var values = context.Messages.Where(x=>x.SenderMail == email).ToList();
            return View(values);
        }
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(P2_BurgerMenu.Entities.Message message)
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            message.SenderMail = email;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Sendbox", "Message", new { area = "Admin" });
        }
    }
}