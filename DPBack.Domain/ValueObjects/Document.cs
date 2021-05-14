using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DPBack.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DPBack.Domain.ValueObjects
{
    [Owned]
    public class Document
    {
        //single point entry
        public Document(string documentNumber, EDocumentType documentType)
        {
            DocumentNumber = documentNumber;
            DocumentType = documentType;
        }

        [Column("DocumentNumber")]
        [DataType("varchar(32)")]
        public string DocumentNumber{get;  set;}

        [Column("DocumentType")]
        [DataType("bit")]
        public EDocumentType DocumentType {get; set;}

       
    }
}