using System;
using DPBack.Domain.Entities;
using System.Collections.Generic;
using DPBack.Domain.Repositories.Interfaces;

namespace DPBack.Domain.Repositories
{
    public interface IOwnerRepository : IRepository
    {
        Owner GetByNameId(Guid id);

        void Create(Owner owner);
    }
}