using FluentValidation;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class CategoryVMValidator : AbstractValidator<CategoryVM>
    {
        public CategoryVMValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("Ad alanı boş olamaz.")
           .MaximumLength(50).WithMessage("Ad maksimum 50 karakter olmalıdır.");
        }
    }
}
