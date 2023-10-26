using Autofac.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs;
using Ops.Service.Services;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly ICommentService _commentService;
		private readonly IColorService _colorService;
		private readonly ISizeService _sizeService;
        public ProductController(IProductService productService, ICommentService commentService, IColorService colorService, ISizeService sizeService)
        {
            _productService = productService;
            _commentService = commentService;
            _colorService = colorService;
            _sizeService = sizeService;
        }
        public IActionResult Index()
		{
			 return View();
		}
        public async Task<IActionResult> GetAllProduct(int id)
		{
            var products = await _productService.GetAllByIncludeAsync(x => x.CategoryId == id, x => x.ProductFeature,x=>x.ProductFeature.Photos,x=>x.ProductFeature.ColorProductFeatures);

            return View(products.Data);
		}
        public async Task<IActionResult> Detail(int id)
        {
			var sizes =await _sizeService.GetAllActiveAsync();
			var colors =await _colorService.GetAllActiveAsync();
			 var productDetail = await _productService.GetProductDetailsById(id);
			var productCategory =await _productService.GetProductWithCategory(id);
            var comments = await _commentService.GetAllByIncludeParametersAsync(x => x.Customer, x => x.ProductId == id, x => x.IsActive == true);
            ViewBag.ProductCategory=productCategory;
			ViewBag.Sizes=sizes.Data;
			ViewBag.Colors=colors.Data;
			ViewBag.Comments=comments.Data;
             return View(productDetail);
        }
		
    }
}
