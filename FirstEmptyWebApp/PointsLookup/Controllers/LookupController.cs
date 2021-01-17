using Microsoft.AspNetCore.Mvc;
using PointsLookup.Data;
using PointsLookup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointsLookup.Controllers
{
    public class LookupController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LookupController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get Index 
        public IActionResult Index()
        {
            return View();
        }

        //Get LookupPoint
        public IActionResult LookupPoint(string ident)
        {
            if (ident == null)
            {
                return RedirectToAction("Index");
            }
            var student = _db.Students.SingleOrDefault(s => s.IdentNumber == ident);
            return View(student);
        }
    }
    }

