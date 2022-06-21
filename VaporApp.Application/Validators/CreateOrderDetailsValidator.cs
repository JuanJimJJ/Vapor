using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests.OrderDetails;

namespace VaporApp.Application.Validators
{
    class CreateOrderDetailsValidator : AbstractValidator<CreateOrderDetailsRequest>
    {
        public CreateOrderDetailsValidator()
        {
            RuleFor(x => x.IdOrderDetails)
                .NotEmpty()
                .WithMessage("Please insert a product category identification number");
        }
    }
}
