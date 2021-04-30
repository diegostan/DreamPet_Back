using System;
using DPBack.Domain.Entities;
using System.Collections.Generic;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Repositories.Interfaces;

namespace DPBack.Domain.Repositories
{
    public interface IPetsRepository : IRepository
    {
        IEnumerable<BasePet> GetByOwner(Owner owner);
        void Create(Pet pet);
    }
}