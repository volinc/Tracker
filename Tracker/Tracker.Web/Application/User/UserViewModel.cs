﻿namespace Tracker.Web.Application.User
{
    using System;

    public class UserViewModel
    {
        public long Id { get; set; }

        public string Phone { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}
