using System;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Entities.BaseContext;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Commands.OwnerCommands
{
    public class OwnerCreateCommand : BaseEntity, ICommandBase
    {
        public OwnerCreateCommand(){}
        public OwnerCreateCommand(Name name, string address, string fone, Document document, DateTime createDate)
        {
            Name = name;
            Address = address;
            Fone = fone;
            Document = document;
            CreateDate = createDate;
        }

        public Name Name{get; set;}
        public string Address {get; set;}
        public string Fone {get; set;}
        public Document Document {get; set;}
        public DateTime CreateDate{get; set;}       
        
        public bool Validate()
        {
            ClearNotifications();

            if (NameValidations.FirstNameIsNotNull(Name))
                AddNotifications("Name.FirstName", "O nome não pode ser nulo");
                
            
            if (NameValidations.LastNameIsNotNull(Name))
                AddNotifications("Name.LastName", "O sobrenome não pode ser nulo");
            

            if (NameValidations.FirstIsLenghtOk(Name, 3, 20))
                AddNotifications("Name.FirstName", "O nome deve conter entre 3 e 20 caracteres");
                
            if (NameValidations.LastIsLenghtOk(Name, 3, 20))
                AddNotifications("Name.LastName", "O sobrenome deve conter entre 3 e 20 caracteres");
            

            if (Document.DocumentType==EDocumentType.CPF)
            {
                if (!DocumentsValidations.IsCpf(Document.DocumentNumber))
                    AddNotifications("Document.DocumentNumber", "O CPF é inválido");
            }             
            
             if (Document.DocumentType==EDocumentType.CNPJ)
            {
                if (!DocumentsValidations.IsCnpj(Document.DocumentNumber))
                    AddNotifications("Document.DocumentNumber", "O CNPJ é inválido");
            }    
                        

             
            return (Notifications.Count == 0)? true:false;
        }

       
    }
}