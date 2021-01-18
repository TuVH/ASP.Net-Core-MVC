using Microsoft.AspNetCore.Mvc;
using PointsLookup.Data;
using System.Linq;

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
            //Nếu SDB = null => quay về trang index
            if (ident == null)
            {
                return RedirectToAction("Index");
            }
            //Tra về kq thí sinh
            var result = _db.Results.SingleOrDefault(s => s.IdentNumber == ident).Select(s => new
            {
                s.Student.Name,
                s.Student.DateOfBirth,
                s.MathScores,
                s.EnglishScores,
                s.LiteratureScores,
                s.ChemiscalScores,
                s.PhysicalScores,
                s.BiologicalScores
            });
            return View(result);
        }
    }
    }

