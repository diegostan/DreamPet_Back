using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DPBack.Domain.Test.Entities
{
    [TestClass]
    public class OwnerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var owner = new Owner("Dono", "Rua Batman", "(11)9865421", "232.323.123./22");
            var doguinho = new DogPet(Coat.Average, Personality.Calm);
            owner.AddPet(doguinho);
        }
    }
}
