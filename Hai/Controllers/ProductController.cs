using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hai.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hai.Controllers
{
    public class ProductController : Controller
    {
        [Route("")]
        public IActionResult GetList()
        {
            return View();
        }
       
        public IActionResult Create(string name, int price)
        {
            ViewData["name"] = name;
            ViewData["price"] = price;
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete(int ID)
        {
            return new JsonResult(new Product()
            {
                id = ID
                
            });
        }
    }
}