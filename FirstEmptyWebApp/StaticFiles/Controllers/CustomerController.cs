using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StaticFiles.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vip()
        {
            return View();
        }
    }
}
