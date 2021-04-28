using System;

namespace DPBack.Domain
{
    public abstract class BaseEntity : IEquatable<BaseEntity>
    {
        public Guid Id {get; private set;}

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(BaseEntity other)
        {
            return Id == other.Id;
        }
    }


    
}