using System.Collections.Generic;
using DPBack.Domain.Entities;
using DPBack.Domain.Entities.Enums;
using DPBack.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DPBack.Domain.Queries;

namespace DPBack.Domain.Test.Queries
{

    //red green refactory
    [TestClass]
    public class OwnerQueriesTest
    {
        IList<Owner> _owners;
        public OwnerQueriesTest()
        {
            CreateFakeOwners();
        }
        public void CreateFakeOwners()
        {
             _owners = new List<Owner>();

            _owners.Add(
             new Owner(name: new Name(firstName:"Nome1", lastName:"Sobrenome1")
            , address:"Endereço1", fone:"123456789", document:new Document(documentNumber:"123456"
            , documentType:EDocumentType.CPF) 
            ));

            _owners.Add(
            new Owner(name: new Name(firstName:"Nome2", lastName:"Sobrenome2")
            , address:"Endereço2", fone:"123456789", document:new Document(documentNumber:"123456"
            , documentType:EDocumentType.CPF) 
            ));

            _owners.Add(
            new Owner(name: new Name(firstName:"Nome3", lastName:"Sobrenome3")
            , address:"Endereço3", fone:"123456789", document:new Document(documentNumber:"123456"
            , documentType:EDocumentType.CPF)             
            ));
        }

        [TestMethod]
        public void QueryFail()
        {
            var result = _owners.AsQueryable().Where(OwnerQueries.GetByName(
                new Name(firstName:"", lastName:"")
            ));

            Assert.AreEqual(0, result.Count());
        }   

        [TestMethod]
        public void QuerySucess()
        {            
            var result = _owners.AsQueryable().Where(OwnerQueries.GetByName(
                new Name(firstName:"Nome2", lastName:"Sobrenome2")
            ));
            
            Assert.AreEqual(1, result.Count());
        }   
    }
}