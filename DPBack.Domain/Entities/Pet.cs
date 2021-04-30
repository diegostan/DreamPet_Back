using System;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Entities
{
    public class Pet:BasePet
    {
       
        //Single entry point
        public Pet(Name name, Owner owner
        , ESpecie specie, EPersonality personality, string breed, DateTime nasciment) 
        : base(name, owner, nasciment ,specie)
        {             
             Personality = personality;
             Breed = breed;
        }
        public string Breed{get; private set;}
        public ECoat Coat {get; private set;}
        public EPersonality Personality {get; private set;} 

    }
        
}