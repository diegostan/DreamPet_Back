using System;

namespace DPBack.Domain
{
    public class Name:BaseEntity
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName{get;private set;}
        public string LastName{get;private set;}

        public bool NameValidation(Name name)
        {
            if(NameValidations.FirstNameIsNotNull(name)){
             AddNotifications("Name.FirstName", "O nome não pode estar vazio");             
            return false;
            }

           if(NameValidations.LastNameIsNotNull(name)){
             AddNotifications("Name.LastName",  "O nome não pode estar vazio");
            return false;
            }

            
            
            return true;
        }

      
        
    }
}