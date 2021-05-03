using System;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Entities
{
    public class PetCreateCommand : BaseEntity, ICommandBase
    {
        public Name Name {get;private set;}
        public Guid OwnerId {get; private set;}
        public EPetSize Size {get; private set;}
        public string IdentityNumber {get;private set;}
        public DateTime NascimentDate{get; private set;}
        public ESpecie Specie {get; private set;}
        public string Breed{get; private set;}
        public ECoat Coat {get; private set;}
        public EPersonality Personality {get; private set;} 

        public bool Validate()
        {

            return true;
        }
    }
}