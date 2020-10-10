namespace Tracker.Web.Application.User.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Taxys.Domain;

    public class UserQueryHandler : IRequestHandler<UserQuery, UserViewModel>
    {
        public Task<UserViewModel> Handle(UserQuery request, CancellationToken cancellationToken)
        {
            return request.UserId switch
            {
                1 => Task.FromResult(new UserViewModel {Id = 1, Name = "1"}),
                2 => Task.FromResult(new UserViewModel {Id = 2, Name = "2"}),
                _ => throw new EntityNotFoundException()
            };
        }
    }
}