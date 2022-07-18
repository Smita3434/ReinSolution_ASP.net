using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReinSolution_ASP.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReinSolution_ASP.net.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product{Id=101,Name="HP Laptop",Price=55000},
                new Product{Id=102,Name="Dell Laptop",Price=75000},
                new Product{Id=103,Name="Mac Laptop",Price=87000},
            };

            ViewBag.Productlist = plist;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];
            return View("Details");
        }
    }
}
