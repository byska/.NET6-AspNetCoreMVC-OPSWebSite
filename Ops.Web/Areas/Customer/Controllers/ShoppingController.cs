using Microsoft.AspNetCore.Mvc;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCart()
        {
            return View();
        }
        public IActionResult AddItemCart()
        {
            return RedirectToAction("GetCart");
        }
    }
}
