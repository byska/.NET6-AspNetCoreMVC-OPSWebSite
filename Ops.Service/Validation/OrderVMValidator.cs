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
            .InclusiveBetween(0,int.MaxValue).WithMessage("Sepetinize ürün ekleyiniz.");
        }
    }
}
