using FluentValidation;
using VaporApp.Application.Requests.Products;

namespace VaporApp.Application.Validators
{
    class CreateProductsValidator : AbstractValidator<CreateProductsRequest>
    {
        public CreateProductsValidator()
        {
            RuleFor(x => x.ProductPrice)
                .NotEmpty()
                .WithMessage("Product price required");

            RuleFor(x => x.ProductSku)
                .NotEmpty()
                .WithMessage("SKU required");

            RuleFor(x => x.ProductStock)
                .NotEmpty()
                .WithMessage("Stock required");
        }
    }
}
