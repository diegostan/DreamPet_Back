using DPBack.Domain.Commands;
using DPBack.Domain.Handlers;
using DPBack.Domain.Repositories;
using DPBack.Domain.Test.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain.Test.Handlers
{
    [TestClass]
    public class OwnerCreateHandleTest
    {
    
        //Teste de falha do OwnerCreateHandler
        [TestMethod]
        public void HandlerFail()
        {
            var command = new OwnerCreateCommand();
            command.Name = new ValueObjects.Name{FirstName="", LastName=""};           

            command.Document = new ValueObjects.Document("00000000", Entities.Enums.EDocumentType.CPF);

            var handle = new OwnerCreateHandler(new OwnerRepositoryTest());
            var result = (CommandResult)handle.Handle(command);

            Assert.AreEqual(false, result.Ok);
        }
        
       
    }
}