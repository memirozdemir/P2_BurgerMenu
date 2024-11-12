using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using System.Web.UI.WebControls;
using System.Windows.Markup;

namespace P2_BurgerMenu.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            var values = context.Reservations.ToList();
            return View(values);
        }
        public ActionResult Details(int id) 
        {
            var values = context.Reservations.Where(x=>x.ReservationID == id).ToList();
            return View(values);
        }
		public ActionResult StatusChangedToConfirm(int id)
		{
			var value = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
			value.ResStatus = "Onaylandı";
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult StatusChangedToCancel (int id)
		{
			var value = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
			value.ResStatus = "İptal edildi";
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult EditReservation(int id)
		{
			var values = context.Reservations.Find(id);
			return View(values);
		}
		[HttpPost]
		public ActionResult EditReservation(Reservation reservation)
		{
			var value = context.Reservations.Find(reservation.ReservationID);
			value.Name = reservation.Name;
			value.Surname = reservation.Surname;
			value.Email = reservation.Email;
			value.Phone = reservation.Phone;
			value.PplCount = reservation.PplCount;
			value.ResDate = reservation.ResDate;
			value.Time = reservation.Time;
			value.ResStatus = reservation.ResStatus;
			value.Message = reservation.Message;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}