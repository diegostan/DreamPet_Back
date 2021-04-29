using System;

namespace DPBack.Domain
{
    public abstract class BasePet: BaseEntity
    {      

        protected BasePet(Name name, Owner owner, EPetSize size):base()
        {
            Name = name;            
            Owner = owner;            
            Size = size;            
        }

        public Name Name {get;private set;}
        public string IdentityNumber {get;private set;}
        public Owner Owner {get; private set;}
        public Guid OwnerGuid {get;private set;}
        public EPetSize Size {get; private set;}        

        public void SetName(Name name)
        {            
            Name = name;
        }
        
    }   
}