using Microsoft.AspNetCore.Mvc;
using StokTakip.web.Repository;

namespace StokTakip.web.Controllers
{
    public class ProductController : Controller
    {

        private readonly BaseDbContext _baseDbContext;
        public ProductController(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
                
        }

        public IActionResult Index()
        {
            var products = _baseDbContext.Products;
            return View();
        }
        [HttpGet]
        public IActionResult Crate() 
        {
            return View();

        }
    }
}
