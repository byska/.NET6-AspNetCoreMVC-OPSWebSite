using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = "customer")]
    public class ProfileController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly IOrderService _orderService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;
        public ProfileController(UserManager<AppUser> userManager, IProductService productService, IMapper mapper, IAddressService addressService, ICommentService commentService, IOrderService orderService, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _addressService = addressService;
            _mapper = mapper;
            _commentService = commentService;
            _orderService = orderService;
            _signInManager = signInManager;
            _productService = productService;
        }

        public async Task<IActionResult> UserProfile()
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            return View(_mapper.Map<UserVM>(user));
        }
        /// <summary>
        /// user detail update
        /// </summary>
        /// <param name="userVM"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UserProfile(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByEmailAsync(userVM.Email);
                user.PhoneNumber = userVM.PhoneNumber;
                user.FirstName = userVM.FirstName;
                user.LastName = userVM.LastName;
                user.Email = userVM.Email;
                user.DateOfBirth = userVM.DateOfBirth;
                IdentityResult result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, true);
                    ViewData["userUpdateResult"] = "Güncelleme işleminiz başarıyla gerçekleştirildi.";
                    return View(userVM);
                }
                else
                {
                    result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                    ViewData["userUpdateError"] = "Güncelleme işleminiz gerçekleştirilemedi.";
                    return View(userVM);
                }
            }
            return View(userVM);
        }

        /// <summary>
        /// şifre güncelleme kısmı.
        /// </summary>
        /// <returns></returns>
        public IActionResult UpdatePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordVM updatePassword)
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            var passwordMatched = await _userManager.CheckPasswordAsync(user, updatePassword.OldPassword);
            if (passwordMatched)
            {
                if (updatePassword.Password == updatePassword.PasswordRetry)
                {

                    IdentityResult result = await _userManager.ChangePasswordAsync(user, updatePassword.OldPassword, updatePassword.Password);
                    if (result.Succeeded)
                    {
                        TempData["userPasswordUpdateResult"] = "Şifreniz başarıyla değiştirildi.";
                        await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        return RedirectToAction("Login", "User");
                    }
                    else
                    {
                        TempData["userPasswordUpdateError"] = "İşlem Gerçekleştirilemedi.";
                        result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                        return View();
                    }
                }
                else
                {
                    TempData["userPasswordUpdateError"] = "Girilen şifreler birbiriyle aynı değil.";
                    return View();
                }
            }
            else
            {
                TempData["userPasswordUpdateError"] = "Güncel şifreniz doğru değil.";
                return View();
            }

        }

        public async Task<IActionResult> GetUserAddress()
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            var addressList = (await _addressService.GetAllByIncludeAsync(x => x.CustomerId == user.Id, x => x.City, x => x.County)).Data.ToList();
            return View(addressList);
        }

        public async Task<IActionResult> AddUserAddress()
        {
            List<string> cities = await _addressService.GetCities();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAddress(AddressCreateVM addressCreateVM)
        {
            
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            addressCreateVM.CustomerId = user.Id;
            if (ModelState.IsValid)
            {
                var address = await _addressService.AddAsync(addressCreateVM);
                if (address.Data != null && address.Errors == null)
                {
                    ViewData["userAddressResult"] = "Adres bilginiz başarıyla eklenmiştir.";
                    return RedirectToAction("GetUserAddress");
                }
                else
                {
                    foreach (var error in address.Errors)
                    {
                        ModelState.AddModelError("addAddress", error);

                    }

                    ViewData["userAddressError"] = "Adres bilginiz eklenemedi.";
                    return View(addressCreateVM);
                }

            }
            return View(addressCreateVM);

        }
        public async Task<IActionResult> UpdateUserAddress(int id)
        {
            AddressVM address = (await _addressService.GetAllByIncludeAsync(x => x.Id == id, x => x.CountyId, x => x.CityId)).Data.FirstOrDefault();
            return View(address);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserAddress(AddressCreateVM addressCreateVM)
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            addressCreateVM.CustomerId = user.Id;
            await _addressService.UpdateAsync(addressCreateVM);
            return RedirectToAction("GetUserAddress");
        }
        public async Task<IActionResult> DeleteUserAddress(int id)
        {
            await _addressService.RemoveAsync(id);
            return RedirectToAction("GetUserAddress");
        }
        public async Task<IActionResult> GetUserComment()
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            var comments = (await _commentService.GetAllByIncludeAsync(x => x.CustomerId == user.Id)).Data.ToList();
            return View(comments);
        }
        public async Task<IActionResult> AddUserComment()
        {
            IEnumerable<OrderVM> ordersVM = (await _orderService.GetAllActiveAsync()).Data;
            if (ordersVM.Count() > 0)
            {
                List<ProductCommentSelectListVM> selectList = new List<ProductCommentSelectListVM>();
                foreach (var orders in ordersVM)
                {
                    foreach (var product in orders.ProductId)
                    {
                        var productVM = (await _productService.GetByIdAsync(product)).Data;
                        ProductCommentSelectListVM productSelectList = _mapper.Map<ProductCommentSelectListVM>(productVM);
                        selectList.Add(productSelectList);
                    }

                }
                ViewBag.SelectList = selectList;
                return View();
            }
            TempData["NotOrder"] = "Yorum yapabileceğiniz bir siparişiniz yok.";
            return RedirectToAction("GetUserComment");


        }
        [HttpPost]
        public async Task<IActionResult> AddUserComment(CommentCreateVM comment)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.GetUserAsync(HttpContext.User);
                comment.CustomerId = user.Id;
                List<string> errors = (await _commentService.AddAsync(comment)).Errors;
                if (errors.Count > 0)
                {
                    TempData["NotCreateComment"] = "Yorum eklenemedi.";
                    foreach (var item in errors)
                    {
                        ModelState.AddModelError("", item);
                    }

                    return View();
                }
                else
                {
                    TempData["CreateComment"] = "Yorum başarıyla eklendi.";
                    return RedirectToAction("GetUserComment");
                }

            }
            return View(comment);

        }
        public async Task<IActionResult> DeleteUserComment(int id)
        {
            await _commentService.RemoveAsync(id);
            return RedirectToAction("GetUserComment");
        }
        //public async Task<IActionResult> GetUserOrder()
        //{
        //    AppUser user = await _userManager.GetUserAsync(HttpContext.User);
        //    List<OrderVM> orders = (await _orderService.GetAllByIncludeAsync(x => x.CustomerId == user.Id, x => x.Product)).Data.ToList();
        //    return View(orders);
        //}
    }
}
