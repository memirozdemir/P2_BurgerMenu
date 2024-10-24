using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2_BurgerMenu.Entities
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PplCount { get; set; }
        public DateTime ResDate { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
        public string ResStatus { get; set; }
    }
}