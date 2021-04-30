using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.ValueObjects;
using Document = DPBack.Domain.ValueObjects.Document;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPBack.Domain.Entities
{
    [Table("Owners")]
    public class Owner:BaseEntity
    {        
        public Name Name{get;private set;}
        public string Address {get;private set;}
        public string Fone {get; private set;}
        public Document Document {get;private set;}
        public DateTime CreateDate{get; private set;}        
                
        //Single entry point
        public Owner(Name name, string address, string fone, Document document)        
        {
            Name = name;
            Address = address;
            Fone = fone;
            Document = document;
            CreateDate = DateTime.Now;             
        }

    

    }
    
}