using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Commands
{
    class CreateActivity : IAuthenticatedCommand
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
