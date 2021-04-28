using System;
using System.Collections.Generic;

namespace DPBack.Domain
{
    public class Owner:BaseEntity
    {
        List<BasePet> _listPets;
        public string Name{get;private set;}
        public string Address {get;private set;}
        public string Fone {get; private set;}
        public string Document {get;private set;}
        public DateTime CreateDate{get; private set;}
        public IReadOnlyCollection<BasePet> Pets {get; internal set;}
        
        //Single entry point
        public Owner(string name, string address, string fone, string document)        
        {
            Name = name;
            Address = address;
            Fone = fone;
            Document = document;
            _listPets = new List<BasePet>();
        }

        
        public bool AddPet(BasePet pet)
        {
            _listPets.Add(pet);
            Pets = _listPets;
            return true;
        }

        public bool RemovePet(BasePet pet)
        {
            _listPets.Remove(pet);
            Pets = _listPets;
            return true;
        }
        public IReadOnlyCollection<BasePet> GetPets()
        {
            return Pets;
        }

    }
    
}