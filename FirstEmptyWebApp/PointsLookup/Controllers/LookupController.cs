using Microsoft.AspNetCore.Mvc;
using PointsLookup.Data;
using PointsLookup.Models;
using PointsLookup.ViewModel;
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
            var result = (from s in _db.Results
                          from u in _db.Students
                          where s.CMND_Student == u.CMND && s.IdentNumber.Equals(ident)
                          select new
                          {
                              u.Name,
                              u.DateOfBirth,
                              s.MathScores,
                              s.EnglishScores,
                              s.LiteratureScores,
                              s.ChemiscalScores,
                              s.PhysicalScores,
                              s.BiologicalScores
                          }).FirstOrDefault();
            if (result != null)
            {
                var finalResult = new SearchResultViewModel
                {
                    Name = result.Name,
                    MathScore = result.MathScores,
                    BiologicalScores = result.BiologicalScores,
                    ChemiscalScores = result.ChemiscalScores,
                    EnglishScores = result.EnglishScores,
                    DateOfBirth = result.DateOfBirth,
                    LiteratureScores = result.LiteratureScores,
                    PhysicalScores = result.PhysicalScores
                };
                return View(finalResult);
            }
            return View(result);

        }
    }
}

