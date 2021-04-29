using System;
using System.Collections.Generic;

namespace DPBack.Domain
{
    public abstract class BaseEntity : IEquatable<BaseEntity>
    {
        public Guid Id {get; private set;}
        public IList<Notification> Notifications {get;set;}

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            Notifications = new List<Notification>();
        }

        public bool Equals(BaseEntity other)
        {
            return Id == other.Id;
        }
    }


    
}