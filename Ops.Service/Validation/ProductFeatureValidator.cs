using FluentValidation;
using Ops.Core.VMs.Create;

namespace Ops.Service.Validation
{
    public class ProductFeatureValidator:AbstractValidator<ProductFeatureCreateVM>
    {
        public ProductFeatureValidator()
        {
            RuleFor(x => x.Size)
           .NotEmpty().WithMessage("Ürün boyutu boş olamaz.");

            RuleFor(x => x.Color)
                .NotEmpty().WithMessage("Ürün rengi boş olamaz.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Ürün açıklaması boş olamaz.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("Ürün boş olamaz.")
                .GreaterThan(0).WithMessage("Geçerli bir ürün seçiniz.");
        }
    }
}
