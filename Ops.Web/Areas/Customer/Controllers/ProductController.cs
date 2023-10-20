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
		private readonly IService<Product> _product;
		public ProductController(IService<Product> product)
		{
			_product = product;
			
		}
		public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> GetAllProduct()
		{
			var products= await _product.GetAllAsync();

			return View(products.ToList());
		}
		
        public async Task<IActionResult> Detail()
        {
            var products = await _product.GetAllAsync();

            return View(products.ToList());
        }
		[HttpPost]
        public async Task<IActionResult> Detail(int id)
        {
            var products = await _product.GetAllAsync();

            return View(products.ToList());
        }
    }
}
