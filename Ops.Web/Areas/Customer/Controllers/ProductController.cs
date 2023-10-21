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
			return View(await _productService.GetAllAsync());
		}
		[HttpGet("{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            return View(await _productService.GetProductDetailsById(id));
        }
    }
}
