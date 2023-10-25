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
    public class PhotoVMValidator : AbstractValidator<PhotoCreateVM>
    {
        public PhotoVMValidator()
        {
            RuleFor(x => x.PhotoUrl).MaximumLength(50).WithMessage("Fotoğraf url'si maksimum 50 karakter olmalıdır.").NotNull().WithMessage("Fotoğraf alanı boş geçilemez.").NotEmpty().WithMessage("Adres tanımı alanı boş geçilemez.");
            RuleFor(x => x.ProductFeatureId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir ürün detayı seçiniz.");
            RuleFor(x => x.ColorId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir color seçiniz.");
        }
       
    }
}
