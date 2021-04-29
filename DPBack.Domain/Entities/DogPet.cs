namespace DPBack.Domain
{
    public class DogPet:BasePet
    {
        public Breed BreedId {get; private set;}
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