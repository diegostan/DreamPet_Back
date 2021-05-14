using DPBack.Domain.Commands;
using DPBack.Domain.Commands.OwnerCommands;
using DPBack.Domain.Handlers.OwnerHandlers;
using DPBack.Domain.Test.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain.Test.Handlers
{
    //Red, green, refactory
    [TestClass]
    public class OwnerCreateHandlerTest
    {
    
        //Teste de falha do OwnerCreateHandler
        [TestMethod]
        public void HandlerFail()
        {
            var command = new OwnerCreateCommand();
            command.Name = new ValueObjects.Name(firstName:"", lastName:"");           

            command.Document = new ValueObjects.Document("00000000", Entities.Enums.EDocumentType.CPF);

            var handle = new OwnerCreateHandler(new OwnerRepositoryTest());
            var result = (CommandResult)handle.Handle(command);

            Assert.AreEqual(false, result.Ok);
        }
        
          //Teste de validacao do OwnerCreateHandler
        [TestMethod]
        public void HandlerValid()
        {
            var command = new OwnerCreateCommand();
            command.Name = new ValueObjects.Name(firstName:"Diego", lastName:"Magalhaes");           
            
            command.Document = new ValueObjects.Document("42413399054", Entities.Enums.EDocumentType.CPF);

            var handle = new OwnerCreateHandler(new OwnerRepositoryTest());
            var result = (CommandResult)handle.Handle(command);

            Assert.AreEqual(true, result.Ok);
        }
       
    }
}