using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class ProductDetailsView
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice {get;set;}
        public int ProductStock { get; set; }
        public int ProductRating { get; set; }
    }
}
