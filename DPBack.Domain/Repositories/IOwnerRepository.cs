using System;
using DPBack.Domain.Entities;
using System.Collections.Generic;
using DPBack.Domain.Repositories.Interfaces;
using System.Threading.Tasks;

namespace DPBack.Domain.Repositories
{
    public interface IOwnerRepository
    {
       Task<Owner> GetByNameId(Guid id);

        void Create(Owner owner);
    }
}