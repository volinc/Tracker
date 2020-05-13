namespace Tracker.Web.Application
{
    using MediatR;
    
    public class UserCreateCommand : IRequest<UserViewModel>
    {
        public string Phone { get; set; }
    }
}
