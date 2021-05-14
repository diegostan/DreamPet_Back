using System;
using DPBack.Domain.Entities;
using System.Threading.Tasks;

namespace DPBack.Domain.Repositories
{
    public interface IOwnerRepository
    {
       Task<Owner> GetByNameId(Guid id);

        void Create(Owner owner);
    }
}