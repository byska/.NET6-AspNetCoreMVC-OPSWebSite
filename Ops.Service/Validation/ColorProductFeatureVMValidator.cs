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
    public class ColorProductFeatureVMValidator : AbstractValidator<ColorProductFeatureCreateVM>
    {
        public ColorProductFeatureVMValidator()
        {
            RuleFor(x => x.ColorId)
              .InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir renk seçiniz.");
            RuleFor(x => x.ProductFeatureId)
             .InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir ürün özelliği seçiniz.");
        }
    }
}
