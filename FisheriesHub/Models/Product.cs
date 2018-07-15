using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisheriesHub.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
    }
}