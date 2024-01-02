using FluentValidation;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class CartItemVMValidator : AbstractValidator<CartItemVM>
    {
        public CartItemVMValidator()
        {
            RuleFor(x=>x.ProductId).NotNull().WithMessage("Ürün Seçilmeli.").NotEmpty().WithMessage("Ürün Seçilmeli.");
            RuleFor(x => x.Size).NotNull().WithMessage("Lütfen beden seçimi yapınız.").NotEmpty().WithMessage("Lütfen beden seçimi yapınız.");
        }
    }
}
