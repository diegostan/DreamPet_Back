using System;
using System.Linq.Expressions;
using DPBack.Domain.Entities;

namespace DPBack.Domain.Queries
{
    public static class OwnerQueries
    {
        public static Expression<Func<Owner, bool>> GetByNameId(Guid id)
        {
            return (s => s.Id == id); 
        }
        
    }
}