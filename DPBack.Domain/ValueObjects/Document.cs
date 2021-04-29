using System;
using System.Text.RegularExpressions;

namespace DPBack.Domain
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

        public bool DocumentValidation(Document document)
        {
            if (document.DocumentType==EDocumentType.CPF)
            {
                Notifications.Add(new Notification {PropertyName="Document.DocumentNumber", 
                MessageError = "O CPF é inválido"});
                return DocumentsValidations.IsCpf(document.DocumentNumber);
            }

             if (document.DocumentType==EDocumentType.CNPJ)
            {
                Notifications.Add(new Notification {PropertyName="Document.DocumentNumber", 
                MessageError = "O CNPJ é inválido"});
                return DocumentsValidations.IsCnpj(document.DocumentNumber);
            }

            return true;
        }
    }
}