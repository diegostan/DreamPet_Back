using System;
using System.ComponentModel.DataAnnotations;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Entities.Context
{
    public abstract class BasePet: BaseEntity
    {      

        //Single entry point
        protected BasePet(Name name, Owner owner, DateTime nascimentDate, ESpecie specie)
        {
            Name = name;
            Owner = owner;            
            NascimentDate = NascimentDate;
            Specie = specie;
            AgeCalculate(NascimentDate);
        }
        string _age;
        public Name Name {get;private set;}
        public Owner Owner {get; private set;}
        public EPetSize Size {get; private set;}
        public string IdentityNumber {get;private set;}
        public DateTime NascimentDate{get; private set;}
        public ESpecie Specie {get; private set;}
        public string Age{get {return _age;}}

        public virtual void SetName(Name name){}
        public virtual void SetSize(EPetSize size){}
        public virtual void SetIdentityNumber(string number){}  

        internal void AgeCalculate(DateTime date)
        {
            _age = date.Subtract(DateTime.Now).Days.ToString();
        }     
    }   
}