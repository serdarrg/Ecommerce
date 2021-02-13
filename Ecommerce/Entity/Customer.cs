using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entity
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerPhone { get; set; }
        public double Balance { get; set; }
        public int CustomerOrder { get; set; }
        public DateTime LastOrder { get; set; }
    }
}
