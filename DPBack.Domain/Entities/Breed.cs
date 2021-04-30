using System;
using DPBack.Domain.Entities.Context;

namespace DPBack.Domain.Entities
{
    public class Breed:BaseEntity
    {
       

        public Breed(string breedName, BreedCategory category)
        {
            BreedName = breedName;
            Category = category;
        }

        public string BreedName {get; private set;}
        public BreedCategory Category{get;private set;}

    }
}