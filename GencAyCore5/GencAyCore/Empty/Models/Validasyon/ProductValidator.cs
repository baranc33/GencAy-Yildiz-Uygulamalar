using FluentValidation;

namespace Empty.Models.Validasyon
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotNull().WithMessage("Boş Geçilemez").MinimumLength(5).WithMessage("En Az 5 karakter");
        }
    }
}
