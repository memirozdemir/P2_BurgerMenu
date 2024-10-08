using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2_BurgerMenu.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string CustomerName { get; set; }
        public string Comment { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
    }
}