using FluentValidation;

namespace KullanicidanVeriAlmaYöntemleri.Models.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Email).
                NotNull().NotEmpty().
                WithMessage("Email boş olamaz.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Lütfen doğru bir Email giriniz.");

            RuleFor(p => p.Name).NotEmpty().NotNull().
                WithMessage("Lütfen ismi boş geçmeyiniz.").
                MaximumLength(100).WithMessage("Lütfen ürün İsmi 100 karaktereden fazla olmasın.");

        }
    }
}
