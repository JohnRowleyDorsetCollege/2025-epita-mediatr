using _2025_epita_mediatr.Features.Command.User;
using FluentValidation;

namespace _2025_epita_mediatr.Features.Validation
{
    public class CreateUserValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(15).WithMessage("Name is Required");
        }

    }
}
