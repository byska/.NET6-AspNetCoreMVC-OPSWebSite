using FluentValidation;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class CommentVMValidator : AbstractValidator<CommentVM>
    {
        public CommentVMValidator()
        {
            RuleFor(x => x.Description)
           .NotEmpty().WithMessage("Açıklama alanı boş olamaz.")
           .MaximumLength(255).WithMessage("Açıklama en fazla 255 karakter olmalıdır.");

            RuleFor(x => x.Mark)
                .InclusiveBetween(1, 5).WithMessage("Puan 1 ile 5 arasında olmalıdır.");

            RuleFor(x => x.ProductId)
                .InclusiveBetween(1,int.MaxValue).WithMessage("Geçerli bir ürün seçiniz.");
        }
    }
}
