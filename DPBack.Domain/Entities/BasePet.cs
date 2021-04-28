using System;

namespace DPBack.Domain
{
    public abstract class BasePet: BaseEntity
    {
        public string Name {get;private set;}
        public string IdentityNumber {get;private set;}
        public Owner Owner {get; private set;}
        public Guid OwnerGuid {get;private set;}
        public PetSize Size {get; private set;}        

        
        
    }   
}