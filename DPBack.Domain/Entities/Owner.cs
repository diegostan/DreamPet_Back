using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.ValueObjects;
using Document = DPBack.Domain.ValueObjects.Document;

namespace DPBack.Domain.Entities
{
    public class Owner:BaseEntity
    {
        List<BasePet> _listPets;
        public Name Name{get;private set;}
        public string Address {get;private set;}
        public string Fone {get; private set;}
        public Document Document {get;private set;}
        public DateTime CreateDate{get; private set;}
        public IReadOnlyCollection<BasePet> Pets {get; internal set;}
        
        
        //Single entry point
        public Owner(Name name, string address, string fone, Document document)        
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