using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DPBack.Domain.Entities;
using DPBack.Domain.Repositories;

namespace DPBack.Domain.Test.Repositories
{
    public class PetsRepositoryTest : IPetsRepository
    {
        public void Create(Pet pet)
        {
            
        }
        public Task<IList<Pet>> GetByOwnerId(Guid ownerid)
        {
            return null;
        }
    }
}