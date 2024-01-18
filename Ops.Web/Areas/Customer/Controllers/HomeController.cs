using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using System.Diagnostics.Metrics;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]

    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMessageService _messageService;
        private readonly ICommentService _commentService; 
        private readonly IService<HomeSlider, HomeSliderCreateVM, HomeSliderVM> _service;
        public HomeController(IProductService productService,IService<HomeSlider, HomeSliderCreateVM, HomeSliderVM> service,IMessageService messageService,ICommentService commentService)
        {
               _productService = productService;
            _messageService = messageService;
            _commentService = commentService;
            _service = service;
        }
        public async Task<IActionResult> Index()
       {
            var homeSlider= await _service.GetAllActiveAsync();
           var bestsellerProducts= await _productService.GetBestsellerProductsAsync();
           var newProducts= await _productService.GetNewProductsAsync();
            ViewBag.BestsellerProducts=bestsellerProducts.Data;
            ViewBag.NewProducts= newProducts.Data;
            ViewBag.HomeSlider= homeSlider.Data;
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(MessageCreateVM message)
        {
            ModelState.Clear();
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values)
                {
                    // Log the error messages
                    Console.WriteLine(error.Errors[1].ErrorMessage);
                }

                // Diğer işlemler
                return View(message);
            }
            else
            {
                var result = await _messageService.AddAsync(message);
                if (result.Errors == null)
                {
                    TempData["result"] = "Mesajınız başarıyla alınmıştır.";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["result"] = "Mesajınız gönderilememiştir.";
                    return View(message);
                }
            }
        }
        public async Task<IActionResult> About()
        {
            var comments = await _commentService.GetAllByIncludeAsync(x => x.IsActive == true,x=>x.Product,x=>x.Customer) ;
            return View(comments.Data);
        }
        public JsonResult CountiesList(int cityId)
        {
          
                                        


            return Json("deneme");
        }
    }
}
