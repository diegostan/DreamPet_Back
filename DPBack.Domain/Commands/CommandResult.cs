using System.Collections.Generic;
using DPBack.Domain.Commands.Interfaces;

namespace DPBack.Domain.Commands
{
    public class CommandResult:ICommandResult
    {
    

        public CommandResult(bool ok, string propertyName, string message
        , IReadOnlyCollection<Notification> notification)
        {
            Ok = ok;
            PropertyName = propertyName;
            Message = message;
            Notifications = notification;
            
            
        }

        public bool Ok{get;set;}
         public string PropertyName {get;set;}
         public string Message{get;set;}
         public IReadOnlyCollection<Notification> Notifications{get;set;}
    }
}