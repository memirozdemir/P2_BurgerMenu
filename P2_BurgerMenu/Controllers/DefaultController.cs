using P2_BurgerMenu.Context;
using P2_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
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
            var values = context.Abouts.ToList();
            return PartialView(values);
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
            var values = context.Galleries.ToList();
            return PartialView(values);
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
        [HttpPost]
        public PartialViewResult PartialContact(Contact contact)
        {
            contact.SendDate = DateTime.Now;
            context.Contacts.Add(contact);
            context.SaveChanges();
            return PartialView();
        }

        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialReservation(Reservation reservation)
        {
            reservation.ResStatus = "Onay bekleniyor.";
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }
        public ActionResult GetProductsByCategory(int categoryId)
        {
            var products = context.Products.Where(p => p.CategoryID == categoryId).ToList();

            Debug.WriteLine("Ürün sayısı: " + products.Count); // Ürün sayısını kontrol et
            foreach (var product in products)
            {
                Debug.WriteLine("Ürün: " + product.ProductName); // Ürün adlarını yazdır
            }

            return PartialView("_ProductList", products);
        }
        public PartialViewResult _ProductList()
        {
            var values = context.Products.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialLocation()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSubscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialSubscribe(Subscriber subscriber)
        {
            subscriber.SubDate = DateTime.Now;
            context.Subscribers.Add(subscriber);
            context.SaveChanges();
            return PartialView();
        }
    }
}