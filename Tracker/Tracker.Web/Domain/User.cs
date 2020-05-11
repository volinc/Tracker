namespace Tracker.Web.Domain
{
    using System;

    public class User
    {
        public long Id { get; }

        public string Phone { get; }

        public string Email { get; set; }

        public DateTimeOffset CreatedAt { get; }
    }
}
