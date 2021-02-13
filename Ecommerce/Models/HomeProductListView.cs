using Ecommerce.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class HomeProductListView : Controller
    {

        public List<Product> Products { get; set; }
        
    }
}
