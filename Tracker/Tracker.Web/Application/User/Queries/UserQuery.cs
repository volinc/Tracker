namespace Tracker.Web.Application.User.Queries
{
    using MediatR;

    public class UserQuery : IRequest<UserViewModel>
    {
        public UserQuery(long userId)
        {
            UserId = userId;
        }

        public long UserId { get; }
    }
}
