namespace Tracker.Web.Application.User.Commands
{
    using FluentValidation;

    public class CreateUserValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserValidator()
        {
            RuleFor(p => p.Phone).NotNull()
                .Length(10)
                .Matches("^7[0-9]{10}$");
        }
    }
}
