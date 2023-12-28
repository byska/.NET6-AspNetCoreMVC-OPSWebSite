using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ops.Core.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Ops.Web.Extensions;
using Ops.Core.Entities;
using Ops.Core.Services;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingController : Controller
    {
        private readonly IProductService _productService;

        public ShoppingController(IProductService productService)
        {
            _productService = productService;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCart()
        {
            List<CartItemVM> cartItem = HttpContext.Session.GetJson<List<CartItemVM>>("Cart") ?? new List<CartItemVM>();
            CartVM cart = new CartVM()
            {
                CartItems = cartItem,
                GrandTotal = cartItem.Sum(x => x.Quantity * x.Price)
            };
            return View(cart);
        }
        public async Task<IActionResult> AddItemCart(int id)
        {
            var product = (await _productService.GetByIdAsync(id)).Data;
            List<CartItemVM> cart = HttpContext.Session.GetJson<List<CartItemVM>>("Cart") ?? new List<CartItemVM>();
            CartItemVM cartItem = cart.Where(c => c.ProductId == id).FirstOrDefault();

            if (cartItem == null)
            {
                cart.Add(new CartItemVM(product));
            }
            else
            {

                cartItem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Cart", cart);
            TempData["Success"] = "Ürün sepetinize başarıyla eklenmiştir.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> DecreaseItemCart(int id)
        {

            List<CartItemVM> cart = HttpContext.Session.GetJson<List<CartItemVM>>("Cart");
            CartItemVM cartItem = cart.Where(c => c.ProductId == id).FirstOrDefault();

            if (cartItem.Quantity > 1)
            {
                --cartItem.Quantity;
            }
            else
            {
                cart.RemoveAll(x => x.ProductId == id);
            }

            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }

            TempData["Success"] = "Ürün sayısı başarıyla azaltılmıştır.";
            return RedirectToAction("GetCart");
        }
        public async Task<IActionResult> RemoveItemCart(int id)
        {

            List<CartItemVM> cart = HttpContext.Session.GetJson<List<CartItemVM>>("Cart");
            cart.RemoveAll(x => x.ProductId == id);

            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }

            TempData["Success"] = "Ürün sepetinizden başarıyla çıkarılmıştır.";
            return RedirectToAction("GetCart");
        }
        public IActionResult RemoveCart()
        {
            HttpContext.Session.Remove("Cart");

            TempData["Success"] = "Sepetiniz başarıyla temizlenmiştir.";
            return RedirectToAction("GetCart");
        }

    }
}
