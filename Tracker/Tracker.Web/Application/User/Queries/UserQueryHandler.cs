namespace Tracker.Web.Application.User.Queries
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class UserQueryHandler : IRequestHandler<UserQuery, UserViewModel>
    {
        public Task<UserViewModel> Handle(UserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult((UserViewModel)null);
        }
    }
}