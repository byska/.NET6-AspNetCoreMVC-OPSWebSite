using Autofac.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Service.Services;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
	{
		private readonly IProductService _productService;
		public ProductController(IProductService productService)
		{
			_productService = productService;
			
		}
		public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> GetAllProduct()
		{
			var products= await _productService.GetAllAsync();

			return View(products);
		}
		
        public async Task<IActionResult> Detail()
        {
            var products = await _productService.GetAllAsync();

            return View(products);
        }
		[HttpPost]
        public async Task<IActionResult> Detail(int id)
        {
            var products = await _productService.GetAllAsync();

            return View(products);
        }
    }
}
