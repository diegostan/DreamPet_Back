using DPBack.Domain.Repositories.Interfaces;
using DPBack.Domain.Infra.Contexts;
using DPBack.Domain.Entities;

namespace DPBack.Domain.Infra.Repositories
{
    public class PetRepository : IRepository
    {
        readonly PetContext _repositoryContext;
        public void Create(object obj)
        {
            _repositoryContext.Add((Pet)obj);
            _repositoryContext.SaveChanges();
        }
    }
}