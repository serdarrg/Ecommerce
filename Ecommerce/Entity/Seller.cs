using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entity
{
    public class Seller
    {
        public int SellerID { get; set; }
        public string SellerName { get; set; }
        public string StoreName { get; set; }
        public double SellerRating {get;set;}
        public int ProductAmount { get; set; }
        public double WalletBalance { get; set; }
        public DateTime SellerCreateDate { get; set; }
        public double Revenue {get;set;}
    }
}
