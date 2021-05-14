using System;
using System.Linq.Expressions;
using DPBack.Domain.Entities;
using DPBack.Domain.ValueObjects;

namespace DPBack.Domain.Queries
{
    public static class OwnerQueries
    {
        public static Expression<Func<Owner, bool>> GetByNameId(Guid id)
        {
            return (s => s.Id == id); 
        }

        public static Expression<Func<Owner, bool>> GetByName(Name ownerName)
        {
            return (s => s.Name.FirstName == ownerName.FirstName && s.Name.LastName==ownerName.LastName); 
        }
        
    }
}