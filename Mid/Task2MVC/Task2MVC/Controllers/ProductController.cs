using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2MVC.Models;

namespace Task2MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Individual()
        {
            var p = new Product
            {
                Id=1,
                Name= "Mishal",
            };
            return View(p);
        }
        public ActionResult Home()
        {
            List<Product> products = new List<Product>();
            for(int i=0; i<100; i++)
            {
                var p = new Product()
                {
                    Id = i + 1,
                    Name = "Prouct " + (i + 1),
                };
                products.Add(p);
            }
            return View(products);
        }
    }
}