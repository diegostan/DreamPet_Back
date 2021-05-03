using System;
using System.Linq.Expressions;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Context;

namespace DPBack.Domain.Queries
{
    public static class PetsQueries
    {
        public static Expression<Func<BasePet, bool>> GetByOwner(Owner owner)
        {
            return (s => s.OwnerID == owner.Id);
        } 
    }
}