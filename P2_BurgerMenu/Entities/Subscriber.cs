using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2_BurgerMenu.Entities
{
    public class Subscriber
    {
        public int SubscriberID { get; set; }
        public string Gmail { get; set; }
        public DateTime SubDate { get; set; }
    }
}