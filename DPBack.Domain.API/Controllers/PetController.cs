using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DPBack.Domain.Repositories;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Context;

namespace DPBack.Domain.API.Controllers
{
    
    [Authorize]
    [Route("/v1/pets")]
    public class PetController:ControllerBase
    {
        
        [Route("")]
        [HttpGet]
        public IEnumerable<BasePet> GetByNameId([FromServices]IPetsRepository repository, [FromBody]Owner owner)
        {
            return repository.GetByOwner(owner);
        }

        [Route("")]
        [HttpPost]
        public void CreateOwner([FromServices]IOwnerRepository repository, [FromBody]Owner owner, Guid id)
        {
            repository.Create(owner);
        }
    }
}