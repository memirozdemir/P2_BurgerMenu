using P2_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
			int categoryCount = context.Categories.Count();
			int productCount = context.Products.Count();
			var mainCourseCount = context.Products.Where(x => x.CategoryID == 1).Count();
			var creditCardCount = context.CreditCards.Count();
			var dealOfTheDayCount = context.Products.Where(x=>x.DealofTheDay==true).Count();
			var contactsCount = context.Messages.Count();
			var subscriberCount = context.Subscribers.Count();
			var confirmedReservationCount = context.Reservations.Where(x => x.ResStatus == "Onaylandı".ToString()).Count();
			var declinedReservationCount = context.Reservations.Where(x => x.ResStatus == "İptal edildi".ToString()).Count();
			var pendingReservationCount = context.Reservations.Where(x => x.ResStatus == "Onay bekleniyor.".ToString()).Count();
			ViewBag.categoryCount = categoryCount;
			ViewBag.productCount = productCount;
			ViewBag.mainCourseCount = mainCourseCount;
			ViewBag.creditCardCount = creditCardCount;
			ViewBag.dealOfTheDayCount = dealOfTheDayCount;
			ViewBag.contactsCount = contactsCount;
			ViewBag.subscriberCount = subscriberCount;
			ViewBag.confirmedReservationCount = confirmedReservationCount;
			ViewBag.declinedReservationCount = declinedReservationCount;
			ViewBag.pendingReservationCount = pendingReservationCount;


			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName.ToString()).Select(y => y.Email).FirstOrDefault();
			var received = context.Messages.Where(x => x.ReceiverMail == email).Count();
			var receivedMessages = received;
			ViewBag.receivedMessages = receivedMessages;
			var send = context.Messages.Where(x => x.SenderMail == email).Count();
			var sentMessages = send;
			ViewBag.sentMessages = sentMessages;
			return View();
        }
    }
}