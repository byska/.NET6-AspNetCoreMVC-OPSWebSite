using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class CustomIdentityErrorDescriber :IdentityErrorDescriber
    {
        public override IdentityError DuplicateEmail(string email) => new IdentityError { Code = "DuplicateEmail", Description = $"\"{email}\" başka bir kullanıcı tarafından kullanılmaktadır." };
        public override IdentityError InvalidEmail(string email) => new IdentityError { Code = "InvalidEmail", Description = "Geçersiz email." };
        public override IdentityError PasswordRequiresDigit() => new IdentityError { Code = "PasswordDigit", Description = "Şifreniz sayı değeri içermeli." };
        public override IdentityError PasswordRequiresLower() => new IdentityError { Code = "PasswordLower", Description = "Şifreniz küçük harf içermeli." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new IdentityError { Code = "PasswordAlp", Description = "Şifreniz geçersizdir." };
        public override IdentityError PasswordRequiresUpper() => new IdentityError { Code = "PasswordUpper", Description = "Şifreniz büyük harf içermelidir." };
        public override IdentityError PasswordTooShort(int length) => new IdentityError { Code = "PasswordLength", Description = "Şifreniz çok kısa." };

    }
}
