using AutoMapper;
using Facebook;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using Ops.Repository;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Web;
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
        public IActionResult GoogleLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("ExternalResponse", "User", new { ReturnUrl = ReturnUrl });
            AuthenticationProperties properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }
        public async Task<IActionResult> ExternalResponse(string ReturnUrl="/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
                return RedirectToAction("Login");

            else
            {
                SignInResult loginResult = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);
                if (loginResult.Succeeded)
                    return Redirect(ReturnUrl);
                else
                {
                    AppUser user = new AppUser
                    {
                        Email = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value
                    };
                    IdentityResult createResult= await _userManager.CreateAsync(user);
                    if(createResult.Succeeded)
                    {
                        IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);
                        if(addLoginResult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                    } 
                }
            }
           return Redirect(ReturnUrl);
        }

        public IActionResult FacebookLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "User", new { ReturnUrl = ReturnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);

            return new ChallengeResult("Facebook", properties);
        }

        public async Task<IActionResult> FacebookResponse(string ReturnUrl = "/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
                return RedirectToAction("Login");
            else
            {
                AppUser user = new AppUser
                {
                    Email = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value

                };
                IdentityResult createResult = await _userManager.CreateAsync(user);

                if (createResult.Succeeded)
                {
                    IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);
                    if (addLoginResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, true);
                        return Redirect(ReturnUrl);
                    }
                }
            }
            return Redirect(ReturnUrl);
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
                    var resultRole = await _userManager.AddToRoleAsync(appUser, "customer");
                    TempData["CreateUser"] = "Kullanıcı başarıyla oluşturuldu.";
                    return RedirectToAction("Login");
                }
                else
                {
                    TempData["NotCreateUser"] = "Kullanıcı oluşturulamadı.";
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View();
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
                        //return RedirectToAction("Cart", "Shopping");
                        return RedirectToAction("GetCart", "Shopping");
                    }
                }
                else
                {
                    ModelState.AddModelError("login", "Hatalı kullanıcı adı veya şifre.");
                    TempData["ErrorLogin"] = "Hatalı kullanıcı adı veya şifre.";
                }

            }
            return View(loginVM);
        }

        /// <summary>
        /// mailden yönlendirip gelinen şifre sıfırlama alanı.
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]/{userId}/{token}")]
        public IActionResult ForgetPassword(string userId, string token)
        {
            return View();
        }
        [HttpPost("[action]/{userId}/{token}")]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM password, string userId, string token)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);
            IdentityResult result = await _userManager.ResetPasswordAsync(user, HttpUtility.UrlDecode(token), password.Password);
            if (result.Succeeded)
            {
                ViewBag.State = true;
                await _userManager.UpdateSecurityStampAsync(user);
            }
            else
                ViewBag.State = false;
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
        public async Task<IActionResult> Reset(ResetPasswordModel password)
        {
            AppUser user = await _userManager.FindByEmailAsync(password.Email);
            if (user != null)
            {
                string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);

                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.To.Add(user.Email);
                mail.From = new MailAddress("orangepressstore@gmail.com", "Şifre Güncelleme", System.Text.Encoding.UTF8);
                mail.Subject = "Şifre Güncelleme Talebi";
                mail.Body = $"<a target=\"_blank\" href=\"https://localhost:7245{Url.Action("ForgetPassword", "User", new { userId = user.Id, token = HttpUtility.UrlEncode(resetToken) })}\">Yeni şifre talebi için tıklayınız</a>";
                mail.IsBodyHtml = true;
                SmtpClient smp = new SmtpClient();
                smp.Credentials = new NetworkCredential("orangepressstore@gmail.com", "Beste1998.");
                smp.Port = 587;
                smp.Host = "smtp.gmail.com";
                smp.EnableSsl = true;
                smp.Send(mail);

                ViewBag.State = true;
            }
            else
                ViewBag.State = false;
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
                ViewData["Error"] = $"{item.Code}-{item.Description}";
            }
        }
    }
}
