
using DPBack.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]        
        public void VerificaNome()
        {
            var name = new Name("Diego", "Magalhaes");
            Assert.IsTrue(name.NameValidation(name));            
        }       
       
    }
}