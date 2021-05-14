using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DPBack.Domain.Repositories;
using System.Collections.Generic;
using DPBack.Domain.Entities;
using DPBack.Domain.Handlers.PetHandlers;
using DPBack.Domain.Commands;
using DPBack.Domain.Commands.PetCommands;
using System.Threading.Tasks;

namespace DPBack.Domain.API.Controllers
{


    [Route("/v1/pets")]
    public class PetController : ControllerBase
    {
        [AllowAnonymous]
        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IEnumerable<Pet>> GetByOwnerId([FromServices] IPetsRepository repository
        , Guid id
        )
        {
            var result = await repository.GetByOwnerId(id);
            return result;
        }

        [AllowAnonymous]
        [Route("")]
        [HttpPost]
        public CommandResult CreatePet([FromBody] PetCreateCommand command
       , [FromServices] PetCreateHandler handler)
        {
            return (CommandResult)handler.Handle(command);
        }

        [AllowAnonymous]
        [Route("{id:guid}")]
        [HttpDelete]
        public CommandResult DeletePet([FromServices]PetDeleteHandler handler 
        , Guid id)
        {           
            var command = new PetDeleteCommand();
            command.PetId= id;
            return (CommandResult)handler.Handle(command);
        }
    }
}