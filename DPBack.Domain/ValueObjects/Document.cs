using System;
using System.Text.RegularExpressions;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DPBack.Domain.ValueObjects
{
    
    public class Document
    {
        public Document(string documentNumber, EDocumentType documentType)
        {
            DocumentNumber = documentNumber;
            DocumentType = documentType;
        }
        public string DocumentNumber{get;  set;}
        public EDocumentType DocumentType {get; set;}

       
    }
}