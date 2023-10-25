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
    public class ColorVMValidation : AbstractValidator<ColorCreateVM>
    {
        public ColorVMValidation()
        {
                RuleFor(x=>x.Name).MaximumLength(50).WithMessage("Renk maksimum 50 karakter olmalıdır.")
                .NotNull().WithMessage("Renk alanı boş geçilemez.").NotEmpty().WithMessage("Renk alanı boş geçilemez.");
        }
    }
}
