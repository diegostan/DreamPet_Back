using DPBack.Domain.Repositories.Interfaces;
using DPBack.Domain.Infra.Contexts;
using DPBack.Domain.Entities;

namespace DPBack.Domain.Infra.Repositories
{
    public class OwnerRepository : IRepository
    {
        readonly OwnerContext _repositoryContext;
        public void Create(object obj)
        {
            _repositoryContext.Add((Owner)obj);
            _repositoryContext.SaveChanges();
        }
    }
}