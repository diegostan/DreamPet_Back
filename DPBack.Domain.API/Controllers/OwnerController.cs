using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DPBack.Domain.Repositories;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using DPBack.Domain.Entities;

namespace DPBack.Domain.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/v1/owner")]
    public class OwnerController:Controller
    {
        
        [Route("")]
        [HttpGet]
        public Owner GetByNameId([FromServices]IOwnerRepository repository, [FromBody]Guid id)
        {
            return repository.GetByNameId(id);
        }

        [Route("")]
        [HttpPost]
        public void CreateOwner([FromServices]IOwnerRepository repository, [FromBody]Owner owner, Guid id)
        {
            repository.Create(owner);
        }
    }
}