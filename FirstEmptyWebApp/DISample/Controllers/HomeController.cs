using DISample.Services;
using Microsoft.AspNetCore.Mvc;


namespace DISample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        HomeController()
        {
            _productService = new ProductService();
        }
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}
