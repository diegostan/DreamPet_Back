using System;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Context;

namespace DPBack.Domain.ValueObjects
{
    public sealed class Name:BaseEntity
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
            if(!NameValidations.FirstNameIsNotNull(name)){
                AddNotifications("Name.FirstName", "O nome não pode estar vazio");             
                return false;}
                

           if(!NameValidations.LastNameIsNotNull(name)){
                AddNotifications("Name.LastName",  "O nome não pode estar vazio");
                return false;}
                

            if(!NameValidations.FirstIsLenghtOk(name, 3, 20)){
                AddNotifications("Name.First",  $"O nome de conter entre 3 e 20 caracteres");
                return false;}
            
            if(!NameValidations.LastIsLenghtOk(name, 3, 20)){
                AddNotifications("Name.Last",  $"O nome de conter entre 3 e 20 caracteres");
                return false;}
                                    
            return true; //IsValid
        }

      
        
    }
}