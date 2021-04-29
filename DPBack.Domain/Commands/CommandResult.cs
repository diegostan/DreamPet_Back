using DPBack.Domain.Commands.Interfaces;

namespace DPBack.Domain.Commands
{
    public class CommandResult:ICommandResult
    {
        public CommandResult(bool ok, string propertyName, string message)
        {
            Ok = ok;
            PropertyName = propertyName;
            Message = message;
        }

        public bool Ok{get;set;}
         public string PropertyName {get;set;}
         public string Message{get;set;}
    }
}