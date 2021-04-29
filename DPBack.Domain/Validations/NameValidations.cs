using DPBack.Domain.Entities;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain
{
    public static class NameValidations
    {
        public static bool FirstNameIsNotNull(Name name)
        {
            if (string.IsNullOrEmpty(name.FirstName))
                return false;

            return true;
        }

        public static bool LastNameIsNotNull(Name name)
        {
            if (string.IsNullOrEmpty(name.LastName))
                return false;
                                    
            return true;
        }

        public static bool FirstIsLenghtOk(Name name, short minLenght, short maxLenght)
        {
            if ((name.FirstName.Length <= minLenght))
                return false;

            if ((name.FirstName.Length >= maxLenght))
                return false;    

            return true; 
        }

         public static bool LastIsLenghtOk(Name name, short minLenght, short maxLenght)
        {
            if ((name.LastName.Length <= minLenght))
                return false;

            if ((name.LastName.Length >= maxLenght))
                return false;    

            return true; 
        }
    }
    
}