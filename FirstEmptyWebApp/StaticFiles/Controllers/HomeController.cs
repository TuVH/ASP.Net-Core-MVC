using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaticFiles.Models;

namespace StaticFiles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //IndexModel a = new IndexModel();
            //a.ID = 1;
            //a.Message = "a";
            //IndexModel b = new IndexModel();
            //b.ID = 2;
            //b.Message = "b";
            //List<IndexModel> product = new List<IndexModel>();
            //product.Add(a);
            //product.Add(b);
            //return View(product);
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new IndexModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(IndexModel index)
        {
            string message = string.Empty;
            message = index.ID + "  " + index.Message;
            return Content(message);
        }
    }
}
