using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class UpdatePasswordVM
    {

        [DataType(DataType.Password, ErrorMessage = "Parolanız gereken değerleri taşımıyor.")]
        public string Password { get; set; }
    }
}
