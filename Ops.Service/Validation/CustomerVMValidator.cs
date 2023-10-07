using FluentValidation;
using Ops.Core.VMs.Create;

namespace Ops.Service.Validation
{
    public class CustomerVMValidator :AbstractValidator<CustomerCreateVM>
    {
        public CustomerVMValidator()
        {
            RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("Telefon numarası boş olamaz.")
            .Matches(@"^\d{10}$").WithMessage("Geçerli bir telefon numarası girin.");
            RuleFor(x => x.DateOfBirth)
            .Must(BeAValidDate).WithMessage("Geçerli bir doğum tarihi girin.");
            RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Ad alanı boş olamaz.")
            .MaximumLength(50).WithMessage("Ad maksimum 50 karakter olmalıdır.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad alanı boş olamaz.")
                .MaximumLength(50).WithMessage("Soyad maksimum 50 karakter olmalıdır.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-posta alanı boş olamaz.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi girin.");
            RuleFor(x => x.Password)
           .NotEmpty().WithMessage("Şifre alanı boş olamaz.")
           .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır.").MaximumLength(25).WithMessage("Şifre en fazla 25 karakter olmalıdır.");

        }
        private bool BeAValidDate(DateTime? date)
        {
            return date.HasValue && date.Value <= DateTime.Now;
        }
    }
}
