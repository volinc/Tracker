namespace Tracker.Web.Application
{
    using FluentValidation;

    public class UserCreateValidator : AbstractValidator<UserCreateCommand>
    {
        public UserCreateValidator()
        {
            RuleFor(p => p.Phone).NotNull()
                .Length(10)
                .Matches("^7[0-9]{10}$");
        }
    }
}
