using System.Collections.Generic;

namespace DPBack.Domain
{
    public class Notification : INotification
    {
        public string PropertyName{get;set;}
        public string MessageError{get;set;}     

    }
}