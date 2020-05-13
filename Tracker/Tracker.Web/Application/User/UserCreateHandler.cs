namespace Tracker.Web.Application
{
    using MediatR;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class UserCreateHandler : IRequestHandler<UserCreateCommand, UserViewModel>
    {
        public Task<UserViewModel> Handle(UserCreateCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UserViewModel
            {
                Id = 1,
                Phone = command.Phone,
                CreatedAt = DateTimeOffset.Now
            });
        }
    }
}
