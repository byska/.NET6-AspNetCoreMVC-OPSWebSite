using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs.Create
{
    public class UserCreateVM
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string LastName { get; set; }


        [DataType(DataType.Password, ErrorMessage = "Parolanız gereken değerleri taşımıyor.")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "Hatalı eposta.")]
        [Required(ErrorMessage = "Lütfen E-mailinizi giriniz.")]
        public string Email { get; set; }
        public bool PersonelDataProtection { get; set; }
        public bool MembershipAgreement { get; set; }
    }
}
