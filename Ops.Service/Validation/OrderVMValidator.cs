using FluentValidation;
using Ops.Core.VMs.Create;

namespace Ops.Service.Validation
{
    public class OrderVMValidator :AbstractValidator<OrderCreateVM>
    {
        public OrderVMValidator()
        {
            RuleFor(x => x.ProductId)
            .NotEmpty().WithMessage("Sepetinize ürün ekleyiniz.")
            .WithMessage("Sepetinize ürün ekleyiniz.");

        }
    }
}
