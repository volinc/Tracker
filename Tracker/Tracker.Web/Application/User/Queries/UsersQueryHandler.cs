namespace Tracker.Web.Application.User.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class UsersQueryHandler : IRequestHandler<UsersQuery, IEnumerable<UserViewModel>>
    {
        public Task<IEnumerable<UserViewModel>> Handle(UsersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Array.Empty<UserViewModel>().AsEnumerable());
        }
    }
}