namespace DPBack.Domain
{
    public class DogPet:BasePet
    {
        public Breed BreedId {get; private set;}
        public Coat Coat {get; private set;}
        public Personality Personality {get; private set;}

        public DogPet(Coat coat, Personality personality)        
        {          
          Coat = coat;
          Personality = personality;
        }
    }
        
}