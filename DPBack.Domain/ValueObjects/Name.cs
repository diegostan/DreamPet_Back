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
            if (string.IsNullOrEmpty(name.FirstName)){
             Notifications.Add(new Notification {PropertyName="Name.FirstName", 
             MessageError = "O nome não pode estar vazio"});
            return false;
            }

            if (string.IsNullOrEmpty(name.LastName)){
             Notifications.Add(new Notification {PropertyName="Name.LastName", 
             MessageError = "O sobrenome não pode estar vazio"});
            return false;
            }
            
            return true;
        }
        
    }
}