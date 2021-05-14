using System.Collections.Generic;
using DPBack.Domain.Commands.Interfaces;

namespace DPBack.Domain.Commands
{
    public class CommandResult:ICommandResult
    {
        private bool v1;
        private string v2;
        private string v3;

        public CommandResult(bool v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

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