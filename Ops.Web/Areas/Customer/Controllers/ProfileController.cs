using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;

namespace Ops.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = "Customer")]
    public class ProfileController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly ICommentService _commentService;
        private readonly IOrderService _orderService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        public ProfileController(UserManager<AppUser> userManager, IMapper mapper, IAddressService addressService, ICommentService commentService, IOrderService orderService)
        {
            _userManager = userManager;
            _addressService = addressService;
            _mapper = mapper;
            _commentService = commentService;
            _orderService = orderService;
        }

        public async Task<IActionResult> UserProfile()
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            return View(_mapper.Map<UserVM>(user));
        }

        [HttpPut]
        public async Task<IActionResult> UserProfile(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = _mapper.Map<AppUser>(userVM);
                IdentityResult result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {

                    ViewData["userUpdateResult"] = "Güncelleme işleminiz başarıyla gerçekleştirildi.";
                    return View(userVM);
                }
                else
                {
                    ViewData["userUpdateError"] = "Güncelleme işleminiz gerçekleştirilemedi.";
                    return View();
                }
            }
            else
            {
                ViewData["userUpdateError"] = "Güncelleme işleminiz gerçekleştirilemedi.";
                return View();
            }
        }

        /// <summary>
        /// şifre güncelleme kısmı.
        /// </summary>
        /// <returns></returns>
        public IActionResult UpdatePassword()
        {
            return View();
        }

        [HttpPut]
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
                        ViewData["userPasswordUpdateResult"] = "Şifreniz başarıyla gerçekleştirildi.";
                        return RedirectToAction("LogOut");
                    }
                    else
                    {
                        ViewData["userPasswordUpdateError"] = "İşlem Gerçekleştirilemedi.";
                        return View();
                    }

                }
                else
                {
                    ViewData["userPasswordUpdateError"] = "Girilen şifreler birbiriyle aynı değil.";
                    return View();
                }
            }
            else
            {
                ViewData["userPasswordUpdateError"] = "Güncel şifreniz doğru değil.";
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAddress(AddressCreateVM addressCreateVM)
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            addressCreateVM.CustomerId = user.Id;
            var address = await _addressService.AddAsync(addressCreateVM);
            if (address.Data != null && address.Errors == null)
            {
                ViewData["userAddressResult"] = "Adres bilginiz başarıyla eklenmiştir.";
                return RedirectToAction("GetUserAddress");
            }
            else
            {
                ViewData["userAddressError"] = "Adres bilginiz eklenemedi.";
                return View(addressCreateVM);
            }

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
        public async Task<IActionResult> DeleteUserComment(int id)
        {
            await _commentService.RemoveAsync(id);
            return RedirectToAction("GetUserComment");
        }
        public async Task<IActionResult> GetUserOrder()
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            List<OrderVM> orders = (await _orderService.GetAllByIncludeAsync(x => x.CustomerId == user.Id, x => x.Product)).Data.ToList();
            return View(orders);
        }
    }
}
