using Autofac.Core;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs;
using Ops.Service.Services;
using System.Drawing;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly ICommentService _commentService;
		private readonly IColorService _colorService;
		private readonly ISizeService _sizeService;
		private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICommentService commentService, IColorService colorService, ISizeService sizeService, ICategoryService categoryService)
        {
            _productService = productService;
            _commentService = commentService;
            _colorService = colorService;
            _sizeService = sizeService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
		{
			 return View();
		}
        public async Task<IActionResult> GetAllProduct(int id)
		{
            var products = await _productService.GetProductsWithColorPhoto(id);
           var category=await _categoryService.GetByIdAsync(id);
            ViewBag.Category = category.Data;
            return View(products.Data);
		}
        [HttpGet]
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
        public async Task<IActionResult> GetAllAccessory(int id)
        {
            List<int> digits = GetDigits(id);
            ViewBag.Digits = digits;
            var accessory = await _productService.GetProductsWithColorPhoto(digits[0]);
            var accessory1 = await _productService.GetProductsWithColorPhoto(digits[1]);
            var accessory2 = await _productService.GetProductsWithColorPhoto(digits[2]);
            var category = await _categoryService.GetByIdAsync(digits[0]);
            var category1 = await _categoryService.GetByIdAsync(digits[1]);
            var category2 = await _categoryService.GetByIdAsync(digits[2]);
            ViewBag.accessory = accessory.Data;
            ViewBag.accessory1 = accessory1.Data;
            ViewBag.accessory2 = accessory2.Data;
            ViewBag.category = category.Data;
            ViewBag.category1 = category1.Data;
            ViewBag.category2 = category2.Data;
            return View();
        }
        private List<int> GetDigits(int number)
        {
            List<int> digits = new List<int>();

            while (number > 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }

            digits.Reverse(); // Ters çevirme işlemi, çünkü sondan başa doğru ekledik

            return digits;
        }

        /// <summary>
        /// Sepete ekle butonu için açıldı. durumuna bakılacak
        /// </summary>
        /// <param name="size"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Order(string size,int quantity)
        {
            
            return View();
        }

    }
}
