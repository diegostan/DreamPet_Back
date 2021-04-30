using System;
using DPBack.Domain.Entities.Context;

namespace DPBack.Domain.Entities
{
    public class BreedCategory:BaseEntity
    {
        public BreedCategory(string category)
        {            
            Category = category;
        }
        
        public string Category {get;private set;}
        
    }
}