using System;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Commands
{
    public class OwnerCreateCommand : BaseEntity, ICommandBase
    {

        public Name Name{get;private set;}
        public string Address {get;private set;}
        public string Fone {get; private set;}
        public Document Document {get;private set;}
        public DateTime CreateDate{get; private set;}        
        
        public bool Validate()
        {
            
            
            if (Document.DocumentType==EDocumentType.CPF)
            {
                AddNotifications("Document.DocumentNumber", "O CPF é inválido");                
                return DocumentsValidations.IsCpf(Document.DocumentNumber);                
            }

             if (Document.DocumentType==EDocumentType.CNPJ)
            {
                AddNotifications("Document.DocumentNumber", "O CNPJ é inválido");                
                return DocumentsValidations.IsCnpj(Document.DocumentNumber);
                
            }

            return true;            
        }

       
    }
}