using Microsoft.AspNetCore.Mvc;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {

        /// <summary>
        /// Sepet sayfası
        /// </summary>
        /// <returns></returns>
        public IActionResult Cart()
        {
            return View();
        }
    }
}
