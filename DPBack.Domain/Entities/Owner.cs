using System;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.ValueObjects;
using Document = DPBack.Domain.ValueObjects.Document;

namespace DPBack.Domain.Entities
{
    public class Owner:BaseEntity
    {                
        public Name Name{get;private set;}

        public string Address {get;private set;}
        public string Fone {get; private set;}
        public Document Document {get;private set;}
        public DateTime CreateDate{get; private set;}        
                

        protected Owner(){}
        //Single entry point
        public Owner(Name name, string address, string fone, Document document)        
        {
            Name = name;
            Address = address;
            Fone = fone;
            Document = document;
            CreateDate = DateTime.Now.Date;             
        }

    

    }
    
}