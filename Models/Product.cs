using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanCentral.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public bool Jersies { get; set; }
        public bool Men { get; set; }
        public bool Women { get; set; }
        public bool Kids { get; set; }
        public bool Shirts { get; set; }
        public bool Sweatshirts { get; set; }
        public bool Hats { get; set; }
        public bool Accessories { get; set; }
        public bool HomeAndOffice { get; set; }
        public bool Collectibles { get; set; }
        public bool Clearance { get; set; }
        public bool Salute { get; set; }
        public bool WearCollection { get; set; }
        public bool NFL100 { get; set; }
        public bool Minshew { get; set; }
        public bool Retired { get; set; }
        public bool Season25 { get; set; }
        public bool Brand { get; set; }
        public bool Sideline { get; set; }
        public bool Players { get; set; }
        public bool Custom { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public decimal Price { get; set; }
    }
}