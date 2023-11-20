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
        [EmailAddress(ErrorMessage = "Hatalı eposta.")]
        [Required(ErrorMessage = "Lütfen E-mailinizi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        [DataType(DataType.Password, ErrorMessage = "Parolanız gereken değerleri taşımıyor.")]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
