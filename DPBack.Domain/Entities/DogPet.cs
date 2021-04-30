using System;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Entities
{
    public class DogPet:BasePet
    {
       
        //Single entry point
        public DogPet(Name name, Owner owner, DateTime age
        , ESpecie specie, EPersonality personality, string breed) 
        : base(name, owner, age, specie)
        {             
             Personality = personality;
             Breed = breed;
        }
        public string Breed{get; private set;}
        public ECoat Coat {get; private set;}
        public EPersonality Personality {get; private set;}
             
    }
        
}