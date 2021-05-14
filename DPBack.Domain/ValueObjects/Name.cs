
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DPBack.Domain.ValueObjects
{        
    [Owned]    
    public class Name
    {
        //single point entry
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [Column("FirstName")]        
        [DataType("varchar(20)")]        
        public string FirstName{get; set;}
        [Column("LastName")]
        [DataType("varchar(20)")]
        public string LastName{get; set;}
     
        
    }
}