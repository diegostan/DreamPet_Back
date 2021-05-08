using System;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;


namespace DPBack.Domain.Entities
{
    public class Pet:BasePet
    {
        protected Pet(){}
              
        //Single entry point
        public Pet(Name name, Guid ownerId
        , ESpecie specie, EPersonality personality, string breed) 
        : base(name, ownerId ,specie)
        {             
             Personality = personality;
             Breed = breed;
        }
        public string Breed{get; private set;}
        public ECoat Coat {get; private set;}
        public EPersonality Personality {get; private set;} 

    }
        
}