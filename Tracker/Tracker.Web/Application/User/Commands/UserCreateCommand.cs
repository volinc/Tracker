namespace Tracker.Web.Application.User.Commands
{
    using MediatR;

    public class UserCreateCommand : IRequest<UserViewModel>
    {
        public string Phone { get; set; }
    }
}
