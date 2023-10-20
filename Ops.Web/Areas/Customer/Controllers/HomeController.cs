using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.Services;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IService<HomeSlider> _service;
        public HomeController(IProductService productService,IService<HomeSlider> service)
        {
               _productService = productService;
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var homeSlider= await _service.GetAllActiveAsync();
           var bestsellerProducts= await _productService.GetBestsellerProductsAsync();
           var newProducts= await _productService.GetNewProductsAsync();
            ViewBag.BestsellerProducts=bestsellerProducts;
            ViewBag.NewProducts= newProducts;
            ViewBag.HomeSlider= homeSlider.ToList();
            return View();
        }
    }
}
