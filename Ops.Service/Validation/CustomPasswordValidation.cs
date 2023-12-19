using Microsoft.AspNetCore.Identity;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class CustomPasswordValidation : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
           List<IdentityError> errors = new List<IdentityError>();
            if(password.Length<5)
            {
                errors.Add(new IdentityError { Code = "PasswordLength", Description = "Şifreniz en az 5 karakter olmalıdır." });
            }
            if(!errors.Any())
                return Task.FromResult(IdentityResult.Success);
            else 
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
        }
    }
}
