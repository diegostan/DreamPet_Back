using System;
using System.ComponentModel.DataAnnotations;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Entities.Context
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
        public Owner Owner {get; private set;}        
        public EPetSize Size {get; private set;}        
        public string IdentityNumber {get;private set;}
        public double Age{get;set;}
        public void SetName(Name name)
        {            
            Name = name;
        }
        
    }   
}