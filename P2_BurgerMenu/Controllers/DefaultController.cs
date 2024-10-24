using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace P2_BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult TodaysOffer()
        {
            var values = context.Products.Where(x=>x.DealofTheDay==true).ToList();
            return PartialView(values);
        }
        
        public PartialViewResult PartialCategory()
        {
            var values = context.Categories.Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialMenu()
        { 
            var values = context.Products.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialReservation(Reservation reservation)
        {
            reservation.ResStatus = "Waiting for confirmation";
            reservation.PplCount = 0;
            reservation.ResDate = DateTime.Now;
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }
    }
}