
using DPBack.Domain.Commands;
using DPBack.Domain.Handlers;
using DPBack.Domain.Test.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain.Test.Handlers
{
    //Red, green, refactory
    [TestClass]
    public class PetCreateHandlerTest
    {
        //Teste de falha do PetsCreateHandler
        [TestMethod]
        public void HandlerFail()
        {            
            var command = new PetCreateCommand();
            command.Name = new ValueObjects.Name(){FirstName="", LastName=""};
            command.Breed = "";
            
            var handle = new PetCreateHandler(new PetsRepositoryTest());
            var result = (CommandResult)handle.Handle(command);

            Assert.AreEqual(false, result.Ok);
        }

        //Teste de validação do PetsCreateHandler
        [TestMethod]
        public void HandlerValid()
        {            
            var command = new PetCreateCommand();
            command.Name = new ValueObjects.Name(){FirstName="Mufasa", LastName="Magalhaes"};
            command.Breed = "Husky";
            
            var handle = new PetCreateHandler(new PetsRepositoryTest());
            var result = (CommandResult)handle.Handle(command);

            Assert.AreEqual(true, result.Ok);
        }
    }
}