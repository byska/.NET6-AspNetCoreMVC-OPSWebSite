using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Ops.Core.Entities;
using Ops.Core.VMs.Create;

namespace Ops.Service.Validation
{
    public class AppUserVMValidator :IUserValidator<AppUser>
    {
        

        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            List<IdentityError> errors = new List<IdentityError>();
            if (user.FirstName.Length < 3 && user.FirstName.Length > 25) //Kullanıcı adının 3 ile 25 karakter arasında olması
                errors.Add(new IdentityError { Code = "FirstnameLength", Description = "İsim 3 - 15 karakter arasında olmalıdır." });
            if (user.LastName.Length < 3 && user.LastName.Length > 25) //Kullanıcı adının 3 ile 25 karakter arasında olması
                errors.Add(new IdentityError { Code = "LastnameLength", Description = "Soyisim 3 - 15 karakter arasında olmalıdır." });
            if (user.Email.Length > 70) // Emailin 70 karakterden fazla olmaması kontrolü
                errors.Add(new IdentityError { Code = "EmailLength", Description = "Email 70 karakterden fazla olamaz." });
            if (user.MembershipAgreement == false || string.IsNullOrWhiteSpace(user.PersonelDataProtection.ToString()))
                errors.Add(new IdentityError { Code = "MembershipAgreement", Description = "Üyelik sözleşmesini kabul etmelisiniz." });
            if (user.PersonelDataProtection == false || string.IsNullOrWhiteSpace(user.PersonelDataProtection.ToString()))
                errors.Add(new IdentityError { Code = "PersonelDataProtection", Description = "Kişisel verilerin korunması şartlarını kabul etmelisiniz." });
            if (!errors.Any())
                return Task.FromResult(IdentityResult.Success);
            else
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
        }

    }
}
