using FluentValidation;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class SizeVMValidation:AbstractValidator<SizeCreateVM>
    {
        public SizeVMValidation()
        {
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Boyut ismi maksimum 50 karakter olmalıdır.")
               .NotNull().WithMessage("Boyut ismi alanı boş geçilemez.").NotEmpty().WithMessage("Boyut ismi alanı boş geçilemez.");
        }
    }
}
