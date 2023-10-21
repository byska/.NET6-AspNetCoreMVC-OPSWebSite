using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IService<HomeSlider, HomeSliderCreateVM, HomeSliderVM> _service;
        public HomeController(IProductService productService,IService<HomeSlider, HomeSliderCreateVM, HomeSliderVM> service)
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
            ViewBag.HomeSlider= homeSlider;
            return View();
        }
    }
}
