using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        protected ActivityCreated()
        {

        }

        public ActivityCreated(Guid userId, Guid id, string category, string name, string description, DateTime createdAt)
        {
            UserId = userId;
            Id = id;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
        }
    }
}
