using FluentValidation;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class ProductVMValidator:AbstractValidator<ProductCreateVM>
    {
        public ProductVMValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Ürün adı boş olamaz.")
            .MaximumLength(255).WithMessage("Ürün adı en fazla 255 karakter olmalıdır.");

            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("Ürün fiyatı boş olamaz.")
                .GreaterThan(0).WithMessage("Ürün fiyatı pozitif bir değer olmalıdır.");

            RuleFor(x => x.Stock)
                .NotEmpty().WithMessage("Ürün stok miktarı boş olamaz.")
                .GreaterThan(0).WithMessage("Ürün stok miktarı pozitif bir değer olmalıdır.");

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("Kategori boş olamaz.")
                .InclusiveBetween(0,int.MaxValue).WithMessage("Geçerli bir kategori seçiniz.");
        }
    }
}
