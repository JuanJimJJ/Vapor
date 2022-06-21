using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests.Categories;

namespace VaporApp.Application.Validators
{
    public class CreateCategoriesValidator : AbstractValidator<CreateCategoriesRequest>
    {
        public CreateCategoriesValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .WithMessage("Category name required");
        }
    }
}
