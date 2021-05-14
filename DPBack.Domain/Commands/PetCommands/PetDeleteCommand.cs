using System;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Entities.BaseContext;

namespace DPBack.Domain.Commands.PetCommands
{
    public class PetDeleteCommand : BaseEntity, ICommandBase
    {
        public Guid PetId{get;set;}
        public bool Validate()
        {
            if((String.IsNullOrEmpty((this.PetId.ToString()))))            
                this.AddNotifications("petId", "Numero do ID inválido");
                
            

            return (this.Notifications.Count ==0)? true:false;
        }
    }
}