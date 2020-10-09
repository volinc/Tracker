namespace Tracker.Web.Application.Token.Commands
{
    using MediatR;

    public class SignOutCommand : IRequest
    {
        public SignOutCommand(long userId)
        {
            UserId = userId;
        }

        public long UserId { get; }
    }
}
