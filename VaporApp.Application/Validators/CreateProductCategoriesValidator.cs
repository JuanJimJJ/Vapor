using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests.ProductCategories;

namespace VaporApp.Application.Validators
{
    class CreateProductCategoriesValidator : AbstractValidator<CreateProductCategoriesRequest>
    {
        public CreateProductCategoriesValidator()
        {
            RuleFor(x => x.IdProductCategory)
                .NotEmpty()
                .WithMessage("Please insert a product category identification number");
        }
    }
}
