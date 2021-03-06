using DPBack.Domain.Infra.Contexts;
using DPBack.Domain.Entities;
using DPBack.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using DPBack.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace DPBack.Domain.Infra.Repositories
{
    public class PetRepository : IPetsRepository
    {
        readonly DataContext _repositoryContext;

        public PetRepository(DataContext context)
        {
            _repositoryContext = context;
        }

        public async Task<IList<Pet>> GetByOwnerId(Guid ownerid)
        {
            var result = await _repositoryContext.Pets.AsNoTracking()
            .Where(PetsQueries.GetByOwnerId(ownerid)).ToListAsync();
            return result;
        }

        public void Create(Pet pet)
        {
            _repositoryContext.Pets.Add(pet);
            _repositoryContext.SaveChanges();
        }

        public void DeleteByPetId(Guid petId)
        {
            var pet =  _repositoryContext.Pets.AsNoTracking()
            .Where(PetsQueries.DeleteByPetId(petId)).FirstOrDefault();
            if(pet is Pet)
            _repositoryContext.Pets.Remove(pet);
            _repositoryContext.SaveChanges();
             
        }
    }
}