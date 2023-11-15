using FluentValidation;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Validation
{
    public class MessageVMValidator :AbstractValidator<MessageCreateVM>
    {
        public MessageVMValidator()
        {

            RuleFor(x => x.Name)
          .NotEmpty().WithMessage("İsim alanı boş olamaz.")
          .MaximumLength(255).WithMessage("İsim en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.Email)
          .NotEmpty().WithMessage("Email alanı boş olamaz.")
          .MaximumLength(255).WithMessage("Email en fazla 128 karakter olmalıdır.");
            RuleFor(x => x.Subject)
          .NotEmpty().WithMessage("Konu alanı boş olamaz.")
          .MaximumLength(255).WithMessage("Konu en fazla 75 karakter olmalıdır.");
            RuleFor(x => x.Description)
          .NotEmpty().WithMessage("Açıklama alanı boş olamaz.")
          .MaximumLength(255).WithMessage("Açıklama en fazla 255 karakter olmalıdır.");
        }
    }
}
