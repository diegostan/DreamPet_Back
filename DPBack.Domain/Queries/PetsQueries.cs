using System;
using System.Linq.Expressions;
using DPBack.Domain.Entities;


namespace DPBack.Domain.Queries
{
    public static class PetsQueries
    {
        public static Expression<Func<Pet, bool>> GetByOwnerId(Guid ownerid)
        {
            return (s => s.OwnerID == ownerid);
        }

        public static Expression<Func<Pet, bool>> DeleteByPetId(Guid petId)
        {
            return (S => S.Id == petId);
        }
    }
}