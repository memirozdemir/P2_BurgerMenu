using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2_BurgerMenu.Entities
{
    public class DealOfTheDay
    {
        public int DealOfTheDayID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }

    }
}