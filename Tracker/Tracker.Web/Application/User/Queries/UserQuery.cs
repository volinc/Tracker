namespace Tracker.Web.Application.User.Queries
{
    using MediatR;

    public class UserQuery : IRequest<UserViewModel>
    {
        public long UserId { get; set; }
    }
}
