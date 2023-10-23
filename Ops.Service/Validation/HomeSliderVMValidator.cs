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
    public class HomeSliderVMValidator : AbstractValidator<HomeSliderVM>
    {
        public HomeSliderVMValidator()
        {
            RuleFor(x => x.PhotoUrl)
       .NotEmpty().WithMessage("Fotoğraf yükleme alanı boş olamaz.");
            RuleFor(x => x.Title)
           .MaximumLength(50).WithMessage("Başlık maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.Subtitle)
           .MaximumLength(50).WithMessage("Alt başlık maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("Kategori Seçiniz.")
            .InclusiveBetween(0, int.MaxValue).WithMessage("Kategori Seçiniz.");
        }
    }
}
