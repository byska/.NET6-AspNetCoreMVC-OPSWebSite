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
    public class AddressVMValidator :AbstractValidator<AddressCreateVM>
    {
        public AddressVMValidator()
        {
            RuleFor(x => x.FirstName)
          .NotEmpty().WithMessage("Ad alanı boş olamaz.")
          .MaximumLength(50).WithMessage("Ad maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.ZIP)
    .Cascade(CascadeMode.StopOnFirstFailure)
    .Must(z => z.Length == 5 && z.All(char.IsDigit))
    .WithMessage("ZIP kodu 5 basamaklı olmalı ve sadece sayı içermelidir.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad alanı boş olamaz.")
                .MaximumLength(50).WithMessage("Soyad maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.PhoneNumber)
           .NotEmpty().WithMessage("Telefon numarası boş olamaz.")
           .Matches(@"^\d{10}$").WithMessage("Geçerli bir telefon numarası girin.");
            RuleFor(x => x.Description).NotNull().WithMessage("Adres tanımı alanı boş geçilemez.").NotEmpty().WithMessage("Adres tanımı alanı boş geçilemez.");
            RuleFor(x => x.CityId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir şehir seçiniz.");
            RuleFor(x => x.CountyId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir ilçe seçiniz.");
            RuleFor(x => x.CustomerId).InclusiveBetween(1, int.MaxValue).WithMessage("Geçerli bir müşteri seçiniz.");
        }
    }
}
