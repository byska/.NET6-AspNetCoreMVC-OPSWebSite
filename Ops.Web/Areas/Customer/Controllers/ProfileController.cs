using Microsoft.AspNetCore.Mvc;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            return View();
        }

    }
}
