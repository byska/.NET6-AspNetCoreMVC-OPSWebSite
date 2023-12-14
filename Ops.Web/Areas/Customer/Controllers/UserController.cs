using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using Ops.Repository;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserCreateVM userCreateVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = _mapper.Map<AppUser>(userCreateVM);
                IdentityResult result = await _userManager.CreateAsync(appUser, userCreateVM.Password);
              
                if (result.Succeeded)
                {
                   var resultRole = await _userManager.AddToRoleAsync(appUser,"customer");
                    ViewData["CreateUser"] = "Kullanıcı başarıyla oluşturuldu.";
                    return RedirectToAction("Login");
                }
                else
                {
                    Errors(result);
                }
            }
            return View(userCreateVM);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);
                if (appUser != null)
                {
                    await _signInManager.SignOutAsync();
                    SignInResult result = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.Remember, false);
                    if (result.Succeeded)
                    {
                        if (appUser.Email == "orangepressstore@gmail.com")
                        {
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        return RedirectToAction("Cart", "Shopping");
                    }
                    ModelState.AddModelError("login", "Hatalı kullanıcı adı veya şifre.");
                }
            }
            return View(loginVM);
        }

        /// <summary>
        /// mailden yönlendirip gelinen şifre sıfırlama alanı.
        /// </summary>
        /// <returns></returns>
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordVM password)
        {
            return View();
        }
        /// <summary>
        /// şifremi unuttum.şifre sıfırlama için mail girme alanı.
        /// </summary>
        /// <returns></returns>
        public IActionResult Reset()
        {
            return View(new ResetPasswordModel());
        }
        [HttpPost]
        public IActionResult Reset(ResetPasswordModel password)
        {
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        private void Errors(IdentityResult result)
        {
            foreach (var item in result.Errors)
            {
                ViewData["Error"]= $"{item.Code}-{item.Description}";
            }
        }
    }
}
