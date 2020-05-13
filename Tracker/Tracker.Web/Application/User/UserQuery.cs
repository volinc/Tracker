namespace Tracker.Web.Application
{
    using MediatR;

    public class UserQuery : IRequest<UserViewModel>
    {
        public long UserId { get; set; }
    }
}
