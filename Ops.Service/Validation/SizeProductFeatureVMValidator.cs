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
    public class SizeProductFeatureVMValidator : AbstractValidator<SizeProductFeatureCreateVM>
    {
        public SizeProductFeatureVMValidator()
        {
            RuleFor(x => x.ProductFeatureId)
             .InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir ürün özelliği seçiniz.");
            RuleFor(x => x.SizeId)
             .InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir beden özelliği seçiniz.");
        }
    }
}
