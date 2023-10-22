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
		private readonly ICommentService _commentService;
		public ProductController(IProductService productService, ICommentService commentService)
		{
			_productService = productService;
			_commentService= commentService;
		}
		public IActionResult Index()
		{
			 return View();
		}
		public async Task<IActionResult> GetAllProduct(int categoryId)
		{
			 return View(await _productService.GetAllByIncludeParametersAsync(x=>x.ProductFeature,x=>x.CategoryId==categoryId,x=>x.IsActive==true));
		}
		[HttpGet("{id}")]
        public async Task<IActionResult> Detail(int productId)
        {
			 var productDetail = await _productService.GetProductDetailsById(productId);
			var productCategory =await _productService.GetProductWithCategory(productId);
			ViewBag.ProductCategory=productCategory;
             return View(productDetail);
        }
		[HttpGet]
		public async Task<IActionResult> GetComment(int productId)
		{
		    var comments=await _commentService.GetAllByIncludeParametersAsync(x => x.Customer, x => x.ProductId == productId,x=>x.IsActive==true);
			return View(comments);
		}
    }
}
