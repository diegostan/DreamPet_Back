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
using System.Linq;
using System.Threading.Tasks;

namespace DPBack.Domain.API.Controllers
{
    
    
    [Route("/v1/pets")]
    public class PetController:ControllerBase
    {
        [AllowAnonymous]        
        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IEnumerable<Pet>> GetByOwnerId([FromServices]IPetsRepository repository
        , Guid id
        )        
        {
            var result = await repository.GetByOwnerId(id);
            return result;
        }
        
        [AllowAnonymous]
        [Route("")]
        [HttpPost]
       public CommandResult CreatePet ([FromBody]PetCreateCommand command
       ,[FromServices]PetCreateHandler handler)
        {
            return (CommandResult)handler.Handle(command);
        }
    }
}