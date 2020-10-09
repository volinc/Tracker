namespace Tracker.Web.Application.User.Commands
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserViewModel>
    {
        public Task<UserViewModel> Handle(CreateUserCommand command, CancellationToken cancellationToken)
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
