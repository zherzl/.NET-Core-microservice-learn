using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get; }
        public string Username { get; }

        protected UserCreated()
        {

        }

        public UserCreated(string email, string username)
        {
            Email = email;
            Username = username;
        }
    }
}