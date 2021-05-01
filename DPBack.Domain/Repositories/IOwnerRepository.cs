using System;
using DPBack.Domain.Entities;
using System.Collections.Generic;
using DPBack.Domain.Repositories.Interfaces;

namespace DPBack.Domain.Repositories
{
    public interface IOwnerRepository
    {
        Owner GetByNameId(Guid id);

        void Create(Owner owner);
    }
}