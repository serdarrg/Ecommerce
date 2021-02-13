using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entity
{
    public class Order
    {
        public int OrderID { get; set; }
        public int Products { get; set; }
        public DateTime OrderDate { get; set; }=DateTime.Now;
        public virtual List<Product> OrderProducts {get;set;}


    }
}
