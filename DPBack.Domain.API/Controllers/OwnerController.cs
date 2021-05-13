using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DPBack.Domain.Repositories;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using DPBack.Domain.Entities;
using DPBack.Domain.Commands;
using DPBack.Domain.Handlers;
using System.Threading.Tasks;

namespace DPBack.Domain.API.Controllers
{
    
    
    [Route("/v1/owner")]
    public class OwnerController:ControllerBase
    {
        
        [AllowAnonymous]        
        [Route("{id:guid}")]
        [HttpGet]
        public async Task<Owner> GetByNameId([FromServices]IOwnerRepository repository, Guid id)
        {          
            var result = await repository.GetByNameId(id);  
            return result;
        }

        [Route("")]
        [HttpPost]
        public CommandResult CreateOwner (
            [FromBody]OwnerCreateCommand command,[FromServices]OwnerCreateHandler handler)
        {
            return (CommandResult)handler.Handle(command);
        }


    }
}