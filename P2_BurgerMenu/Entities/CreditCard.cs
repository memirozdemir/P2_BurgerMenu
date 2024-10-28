using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2_BurgerMenu.Entities
{
    public class CreditCard
    {
        public int CreditCardID { get; set; }
        public string CardNO { get; set; }
        public string CardOwner { get; set; }
        public string CardExpDate { get; set; }
        public string CardCVC { get; set; }
    }
}