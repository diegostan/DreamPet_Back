
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        
        public void VerificaNome()
        {
            var name = new Name("Diego", "M");
            Assert.IsTrue(name.NameValidation(name));
            
        }
    }
}