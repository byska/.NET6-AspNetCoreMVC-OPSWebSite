using Microsoft.AspNetCore.Mvc;
using Ops.Core.VMs;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
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
        public IActionResult UpdatePassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdatePassword(UpdatePasswordVM password)
        {
            return View();
        }
        public IActionResult Reset()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Reset(ResetPasswordModel password)
        {
            return View();
        }
    }
}
