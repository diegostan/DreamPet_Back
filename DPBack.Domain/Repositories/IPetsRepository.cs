using System;
using DPBack.Domain.Entities;
using System.Collections.Generic;
using DPBack.Domain.Entities.BaseContext;
using DPBack.Domain.Repositories.Interfaces;
using System.Threading.Tasks;

namespace DPBack.Domain.Repositories
{
    public interface IPetsRepository
    {
        Task<IList<Pet>> GetByOwnerId(Guid ownerid);
        void Create(Pet pet);

        void DeleteByPetId(Guid petId);
    }
}