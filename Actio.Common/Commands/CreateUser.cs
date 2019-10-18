using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Commands
{
    class CreateUser : ICommand
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

   
}
