using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ops.Core.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Ops.Web.Extensions;
using Ops.Core.Entities;
using Ops.Core.Services;
using System.Drawing;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly UserManager<AppUser> _userManager;

        public ShoppingController(IProductService productService, UserManager<AppUser> userManager, IOrderService orderService)
        {
            _productService = productService;
            _userManager = userManager;
            _orderService = orderService;
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
        public async Task<IActionResult> AddItemCart(int id, string size)
        {
            if (string.IsNullOrEmpty(size))
            {
                TempData["Error"] = "Lütfen bir beden seçiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            var product = (await _productService.GetAllByIncludeAsync(x => x.Id == id, x => x.Photos, x => x.Stock,x=>x.SizeProducts)).Data.FirstOrDefault();
          
            List<CartItemVM> cart = HttpContext.Session.GetJson<List<CartItemVM>>("Cart") ?? new List<CartItemVM>();
            CartItemVM cartItem = cart.Where(c => c.ProductId == id).FirstOrDefault();
            if (product.Stock >= cartItem.Quantity)
            {
                if (cartItem == null)
                {
                    cartItem = new CartItemVM(product, size);
                    cart.Add(cartItem);
                }
                else
                {
                    cartItem.Quantity += 1;
                }
                HttpContext.Session.SetJson("Cart", cart);
                TempData["Success"] = "Ürün sepetinize başarıyla eklenmiştir.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            else
            {
                TempData["Fail"] = "Stok yetersiz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }

           
           
        }
        public async Task<IActionResult> IncreaseItemCart(int id)
        {

            List<CartItemVM> cart = HttpContext.Session.GetJson<List<CartItemVM>>("Cart");
            var product = (await _productService.GetAllByIncludeAsync(x => x.Id == id, x => x.Photos, x => x.Stock)).Data.FirstOrDefault();
            CartItemVM cartItem = cart.Where(c => c.ProductId == id).FirstOrDefault();

            if (cartItem != null)
            {
                cartItem.Quantity += 1;
            }
            if (product.Stock > cartItem.Quantity)
            {
                HttpContext.Session.SetJson("Cart", cart);

                TempData["Success"] = "Ürün sayısı başarıyla azaltılmıştır.";
                return RedirectToAction("GetCart");
            }
            else
            {
                TempData["Fail"] = "Stok yetersiz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
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
        public async Task<IActionResult> ConfirmCart(CartVM cart)
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);

            if (user == null)
            {
                return RedirectToAction("Login", "User");
            }
            else
            {
                if (cart.CartItems.Count() != 0)
                {


                    var result = await _orderService.CreateOrder(cart, user.Id);
                    if (result.StatusCode == 200)
                    {
                        TempData["result"] = "Siparişiniz onaylandı!";
                        return RedirectToAction("GetUserOrder", "Profile");
                    }
                    else
                    {
                        TempData["result"] = "Sipariş Onaylanamadı!";
                        return RedirectToAction("GetCart");
                    }

                }
                else
                {
                    TempData["result"] = "Sepetiniz Boş!";
                    return RedirectToAction("GetCart");
                }
            }

        }
    }
}
