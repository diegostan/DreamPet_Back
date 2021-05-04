using System;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Entities
{
    public class PetCreateCommand : BaseEntity, ICommandBase
    {
        public Name Name {get;set;}
        public Guid OwnerID{get;set;}
        public ESpecie Specie{get;set;}   
        public string Breed{get; set;}        
        public EPersonality Personality {get; set;} 
             
        public bool Validate()
        {            

            return true;
        }
    }
}