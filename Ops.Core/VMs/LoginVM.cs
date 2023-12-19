using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class LoginVM
    {
        [EmailAddress(ErrorMessage = "Hatalı e-mail adresi.")]
        [Required(ErrorMessage = "Lütfen e-mailinizi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
