namespace Tracker.Web.Application
{
    using MediatR;
    using System.Collections.Generic;

    public class UsersQuery : IRequest<IEnumerable<UserViewModel>>
    {
    }
}
