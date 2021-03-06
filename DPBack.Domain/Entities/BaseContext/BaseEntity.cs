using System;
using System.Collections.Generic;

namespace DPBack.Domain.Entities.BaseContext
{
    public abstract class BaseEntity : IEquatable<BaseEntity>
    {
        List<Notification> _listNotifications;
        public Guid Id {get; private set;}
        public IReadOnlyCollection<Notification> Notifications {get{return _listNotifications;}}

        public BaseEntity()
        {
            Id = Guid.NewGuid();            
            _listNotifications = new List<Notification>();
        }

        public bool Equals(BaseEntity other)
        {
            return Id == other.Id;
        }

        public void AddNotifications(string property, string message)
        {
             _listNotifications.Add(new Notification {PropertyName=property, 
             MessageError = message});
        }

        public void ClearNotifications(){_listNotifications.Clear();}
    }


    
}