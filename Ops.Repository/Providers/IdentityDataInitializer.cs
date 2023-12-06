using Microsoft.AspNetCore.Identity;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Providers
{
    public static class IdentityDataInitializer
    {
        public static async Task SeedDataAsync(UserManager<AppUser> _userManager, RoleManager<AppRole> _roleManager)
        {
            await SeedRolesAsync(_roleManager);
            await SeedUserAsync(_userManager);
        }

        public static async Task SeedUserAsync(UserManager<AppUser> _userManager)
        {
            var values = await _userManager.FindByEmailAsync("orangepressstore@gmail.com");
            if (values == null)
            {
                AppUser user = new AppUser
                {
                    UserName="admin",
                    DateOfBirth = new DateTime(1997, 05, 17),
                    Email = "orangepressstore@gmail.com",
                    FirstName = "Ayşe",
                    LastName = "Tabak",
                    PhoneNumber = "05325841236",
                    Status = Core.Enums.Status.Added
                };
                var task =await _userManager.CreateAsync(user, "Beste1998.");
                
                if(task.Succeeded)
                {
                    var response =await _userManager.AddToRoleAsync(user, "admin");
                }
            }
            var valueCustomerData = await _userManager.FindByEmailAsync("besteyasak@gmail.com");
            if (valueCustomerData == null)
            {
                AppUser user = new AppUser
                {
                    UserName = "customer",
                    DateOfBirth = new DateTime(1998, 02, 16),
                    Email = "besteyasak@gmail.com",
                    FirstName = "Beste",
                    LastName = "Yasak",
                    PhoneNumber = "05360249093",
                    Status = Core.Enums.Status.Added
                };
                var task = await _userManager.CreateAsync(user, "Beste1998.");

                if (task.Succeeded)
                {
                    var response = await _userManager.AddToRoleAsync(user, "customer");
                }
            }
        }

        public static async Task SeedRolesAsync(RoleManager<AppRole> _roleManager)
        {
            var value = await _roleManager.RoleExistsAsync("admin");
            if(!value)
            {
                AppRole admin = new AppRole()
                {
                    Name = "admin",
                    NormalizedName = "admin",
                    DisplayName = "Yönetici"
                };
                var adminResult = await _roleManager.CreateAsync(admin);

            }
            if(!_roleManager.RoleExistsAsync("customer").Result)
            {
                AppRole customer = new AppRole()
                {
                    Name = "customer",
                    NormalizedName = "customer",
                    DisplayName = "Müşteri"
                };
                var customerResult = await _roleManager.CreateAsync(customer);
            }
        }
    }
}
