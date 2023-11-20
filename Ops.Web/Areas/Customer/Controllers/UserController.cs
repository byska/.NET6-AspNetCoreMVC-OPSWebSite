using Microsoft.AspNetCore.Mvc;
using Ops.Core.VMs;

namespace Ops.Web.Areas.Customer.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM loginVM)
        {
            return View();
        }
    }
}
