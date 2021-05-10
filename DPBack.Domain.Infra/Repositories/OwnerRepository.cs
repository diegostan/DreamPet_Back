using DPBack.Domain.Repositories.Interfaces;
using DPBack.Domain.Infra.Contexts;
using DPBack.Domain.Entities;
using DPBack.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using DPBack.Domain.Repositories;
using System.Threading.Tasks;

namespace DPBack.Domain.Infra.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        
        readonly DataContext _repositoryContext;

        public OwnerRepository(DataContext context)
        {
            _repositoryContext = context;
        }

        public void Create(Owner owner)
        {
            _repositoryContext.Owners.Add(owner);
            _repositoryContext.SaveChanges();
        }
        

        public async Task<Owner> GetByNameId(Guid id)
        {
            var result = await  _repositoryContext.Owners.AsNoTracking()
           .Where(OwnerQueries.GetByNameId(id)).FirstOrDefaultAsync();            
           return result;
        }
    }
}