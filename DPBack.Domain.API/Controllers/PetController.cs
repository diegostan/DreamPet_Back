using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DPBack.Domain.Repositories;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Context;
using DPBack.Domain.Handlers;
using DPBack.Domain.Commands;

namespace DPBack.Domain.API.Controllers
{
    
    
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
       public CommandResult CreatePet ([FromServices]IPetsRepository repository
        , [FromBody]PetCreateCommand command,[FromServices]PetCreateHandler handler)
        {
            return (CommandResult)handler.Handle(command);
        }
    }
}