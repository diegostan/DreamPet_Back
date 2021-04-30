using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Entities
{
    public class DogPet:BasePet
    {
        public Breed Breed {get; private set;}
        public ECoat Coat {get; private set;}
        public EPersonality Personality {get; private set;}
     

        public DogPet(Name name, Owner owner, EPetSize size, ECoat coat, EPersonality personality)
         : base(name, owner, size)
        {
            Coat = coat;
            Personality = personality;                                    
        }
    }
        
}