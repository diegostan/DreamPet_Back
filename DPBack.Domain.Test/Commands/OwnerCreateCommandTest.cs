using System;
using DPBack.Domain.Commands.OwnerCommands;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain.Test.Commands
{
    [TestClass]
    public class OwnerCreateCommandTest
    {
        //red, green and refactory 

        //teste de falha do command OwnerCreateCommand
        [TestMethod]
        public void CommandFail()
        {                        
            var command = new OwnerCreateCommand(name: new Name(firstName: "", lastName: "")
            , address: "", fone: "", new Document(documentNumber: "", documentType: EDocumentType.CPF)
            , DateTime.Now
            );
            Assert.AreEqual(false, command.Validate());
        }

        //teste de validação do command OwnerCreateCommand
          [TestMethod]
        public void CommandValidade()
        {
            var command = new OwnerCreateCommand(name: new Name(firstName: "User", lastName: "Name")
            , address: "Rua 1234", fone: "12344", new Document(documentNumber: "35724768011"
            , documentType: EDocumentType.CPF)
            , DateTime.Now
            );
            Assert.AreEqual(true, command.Validate());
        }

    }
}