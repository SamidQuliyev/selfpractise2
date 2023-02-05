using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> Products = new List<Product>();
            Products.Add(new Product { Id = 1, Name = "Phone", Price = 290 });
            return View();
        }
    }
}
