namespace Tracker.Web.Application.User.Queries
{
    using System.Collections.Generic;
    using MediatR;

    public class UsersQuery : IRequest<IEnumerable<UserViewModel>>
    {
    }
}
