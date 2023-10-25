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
    public class StockVMValidation : AbstractValidator<StockCreateVM>
    {
        public StockVMValidation()
        {
            RuleFor(x => x.Stocks).NotNull().WithMessage("Stok alanı boş geçilemez.").NotEmpty().WithMessage("Stok alanı boş geçilemez.").InclusiveBetween(0,1000);
            RuleFor(x => x.ProductFeatureId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir ürün detayı seçiniz.");
            RuleFor(x => x.ColorId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir renk seçiniz.");
            RuleFor(x => x.SizeId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir boyut seçiniz.");
        }
    }
}
