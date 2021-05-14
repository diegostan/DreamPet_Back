using System;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Entities.BaseContext;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Commands.PetCommands
{
    public class PetCreateCommand : BaseEntity, ICommandBase
    {
        public PetCreateCommand(){}
        public PetCreateCommand(Name name, Guid ownerID, ESpecie specie, string breed, EPersonality personality)
        {
            Name = name;
            OwnerID = ownerID;
            Specie = specie;
            Breed = breed;
            Personality = personality;
        }

        public Name Name {get;set;}
        public Guid OwnerID{get;set;}
        public ESpecie Specie{get;set;}   
        public string Breed{get; set;}        
        public EPersonality Personality {get; set;} 
             
        public bool Validate()
        {     
             ClearNotifications();

            if (NameValidations.FirstNameIsNotNull(Name))
                AddNotifications("Name.FirstName", "O nome do pet não pode ser nulo");

            if (NameValidations.LastNameIsNotNull(Name))
                AddNotifications("Name.LastName", "O sobrenome do pet não pode ser nulo");
            
            if (NameValidations.FirstIsLenghtOk(Name, 3, 20))
                AddNotifications("Name.FirstName", "O nome do pet deve conter entre 3 e 20 caracteres");

            if (NameValidations.LastIsLenghtOk(Name, 3, 20))
                AddNotifications("Name.LastName", "O sobrenome do pet deve conter entre 3 e 20 caracteres");
            
            if (string.IsNullOrEmpty(Breed))
                AddNotifications("Breed", "A raça não pode estar em branco");

            return (Notifications.Count==0)? true:false;
        }
    }
}