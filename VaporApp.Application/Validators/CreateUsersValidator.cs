using FluentValidation;
using VaporApp.Application.Requests.Users;

namespace VaporApp.Application.Validators
{
    public class CreateUsersValidator : AbstractValidator<CreateUsersRequest>
    {
        public CreateUsersValidator()
        {
            RuleFor(x => x.UserFirstName)
                .NotEmpty()
                .WithMessage("Full name required");

            RuleFor(x => x.UserLastName)
                .NotEmpty()
                .WithMessage("Full name required");

            RuleFor(x => x.UserCountry)
                .NotEmpty()
                .WithMessage("Country required");

            RuleFor(x => x.UserCity)
                .NotEmpty()
                .WithMessage("City required");

            RuleFor(x => x.UserZipcode)
                .NotEmpty()
                .WithMessage("ZIP Code required");

            RuleFor(x => x.UserState)
                .NotEmpty()
                .WithMessage("State required");
        }
    }
}
