using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly HomeContext _context;
        public HomeController(HomeContext context)
        {
            _context = context;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [Route("/products")]
        public IActionResult Products()
        {
            return View();
        }
        [Route("/ProductDetail")]
        public IActionResult ProductDetail()
        {
            return View();
        }
        [Route("/AddProduct")]
        public IActionResult AddProduct()
        {
            return View();
        }
        [Route("/Customers")]
        public IActionResult Customers()
        {
            return View();
        }
        [Route("/Orders")]
        public IActionResult Orders()
        {
            return View();
        }
        [Route("/OrderDetails")]
        public IActionResult OrderDetails()
        {
            return View();
        }
        [Route("/Sellers")]
        public IActionResult Sellers()
        {
            return View();
        }
        [Route("/Shoppingcart")]
        public IActionResult ShoppingCart()
        {
            return View();
        }
        [Route("/Checkout")]
        public IActionResult Checkout()
        {
            return View();
        }


    }
}
