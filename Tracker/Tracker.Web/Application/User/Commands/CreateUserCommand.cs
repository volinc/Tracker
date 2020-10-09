namespace Tracker.Web.Application.User.Commands
{
    using MediatR;

    public class CreateUserCommand : IRequest<UserViewModel>
    {
        public string Phone { get; set; }
    }
}
