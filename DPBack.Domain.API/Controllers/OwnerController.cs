using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DPBack.Domain.Repositories;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using DPBack.Domain.Entities;
using DPBack.Domain.Commands;
using DPBack.Domain.Handlers;

namespace DPBack.Domain.API.Controllers
{
    
    
    [Route("/v1/owner")]
    public class OwnerController:ControllerBase
    {
        [AllowAnonymous]        
        [Route("{id:guid}")]
        [HttpGet]
        public Owner GetByNameId([FromServices]IOwnerRepository repository, Guid id)
        {            
            return repository.GetByNameId(id);
        }

        [Route("")]
        [HttpPost]
        public CommandResult CreateOwner ([FromServices]IOwnerRepository repository
        , [FromBody]OwnerCreateCommand command,[FromServices]OwnerCreateHandler handler)
        {
            return (CommandResult)handler.Handle(command);
        }


    }
}