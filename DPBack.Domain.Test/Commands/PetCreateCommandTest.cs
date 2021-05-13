using System;
using DPBack.Domain.Commands;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain.Test.Commands
{
    [TestClass]
    public class PetCreateCommandTest
    {

        // red green refactory

        //teste de falha do command PetCreateCommand
       [TestMethod]
        public void CommandFail()
        {
            var command= new PetCreateCommand(name:new Name(firstName:"", lastName:"")
            , ownerID: Guid.NewGuid(), specie:ESpecie.Cachorro,breed: "", personality: EPersonality.Angry
            );

            Assert.AreEqual(false, command.Validate());
        }

        //teste de validação do command PetCreateCommand
        [TestMethod]
        public void CommandValidate()
        {
            var command= new PetCreateCommand(name:new Name(firstName:"Bruce", lastName:"Wayne")
            , ownerID: Guid.NewGuid(), specie:ESpecie.Cachorro,breed: "Bat", personality: EPersonality.Docile
            );

            Assert.AreEqual(true, command.Validate());
        }
        
    }
}