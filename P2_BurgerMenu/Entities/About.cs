using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2_BurgerMenu.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string MiniContent { get; set; }
        public string Content { get; set; }
        public string PictureURL { get; set; }
        public bool Status { get; set; }
        public string Address{ get; set; }
        public string Phone{ get; set; }
        public string Mail{ get; set; }
        public string LocationURL { get; set; }
    }
}