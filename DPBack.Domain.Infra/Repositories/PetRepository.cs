using DPBack.Domain.Repositories.Interfaces;
using DPBack.Domain.Infra.Contexts;
using DPBack.Domain.Entities;
using DPBack.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Repositories;

namespace DPBack.Domain.Infra.Repositories
{
    public class PetRepository : IPetsRepository
    {
        readonly DataContext _repositoryContext;

        public PetRepository(DataContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IEnumerable<BasePet> GetByOwner(Owner owner)
        {
            return _repositoryContext.Pets.AsNoTracking()
            .Where(PetsQueries.GetByOwner(owner)).OrderBy(s => s.Name);
        }

        public void Create(Pet pet)
        {
            _repositoryContext.Pets.Add(pet);
            _repositoryContext.SaveChanges();
        }
       
    }
}