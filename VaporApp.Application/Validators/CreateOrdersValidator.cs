using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests.Orders;

namespace VaporApp.Application.Validators
{
    public class CreateOrdersValidator : AbstractValidator<CreateOrdersRequest>
    {
        public CreateOrdersValidator()
        {
            RuleFor(x => x.OrderShippingAddress)
                .NotEmpty()
                .WithMessage("Shipping address is required to ship an item");

            RuleFor(x => x.OrderCity)
                .NotEmpty()
                .WithMessage("City required");

            RuleFor(x => x.OrderZipCode)
                .NotEmpty()
                .WithMessage("Zip code required");

            RuleFor(x => x.OrderCountry)
                .NotEmpty()
                .WithMessage("Country required");

            RuleFor(x => x.OrderState)
                .NotEmpty()
                .WithMessage("State required");
        }
    }
}
