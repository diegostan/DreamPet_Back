using System;
using System.Linq.Expressions;
using DPBack.Domain.Entities;

namespace DPBack.Domain.Queries
{
    public static class BreedQueries
    {
        public static Expression<Func<Breed, bool>> GetBreedByType(Guid categoryBreedId)
        {
            return (s => s.Category.Id == categoryBreedId);
        } 
    }
}