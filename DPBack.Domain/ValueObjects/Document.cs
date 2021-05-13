using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Context;
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