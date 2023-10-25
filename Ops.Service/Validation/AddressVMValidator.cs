using FluentValidation;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class AddressVMValidator :AbstractValidator<AddressCreateVM>
    {
        public AddressVMValidator()
        {
            RuleFor(x => x.Description).NotNull().WithMessage("Adres tanımı alanı boş geçilemez.").NotEmpty().WithMessage("Adres tanımı alanı boş geçilemez.");
            RuleFor(x => x.CityId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir şehir seçiniz.");
            RuleFor(x => x.CountyId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir ilçe seçiniz.");
            RuleFor(x => x.CustomerId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir müşteri seçiniz.");
        }
    }
}
