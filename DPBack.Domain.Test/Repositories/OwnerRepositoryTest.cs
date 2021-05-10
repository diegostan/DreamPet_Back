using System;
using System.Threading.Tasks;
using DPBack.Domain.Entities;
using DPBack.Domain.Repositories;

namespace DPBack.Domain.Test.Repositories
{
    public class OwnerRepositoryTest : IOwnerRepository
    {
        public void Create(Owner owner)
        {
            
        }

        public Task<Owner> GetByNameId(Guid id)
        {
            return null;
        }
    }
}