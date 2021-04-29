using System;
using System.Text.RegularExpressions;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Enums;

namespace DPBack.Domain.ValueObjects
{
    public class Document:BaseEntity
    {
        public Document(string documentNumber, EDocumentType documentType)
        {
            DocumentNumber = documentNumber;
            DocumentType = documentType;
        }

        public string DocumentNumber{get; private set;}
        public EDocumentType DocumentType {get;private set;}

       
    }
}