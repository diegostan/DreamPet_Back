
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPBack.Domain
{
    [TestClass]
    public class DocumentTest
    {
        //Atenção!
        //Esses numeros de documentos foram gerados por um site e não são de pessoas reais (Diego M.)
        [TestMethod]
        [DataTestMethod]
        [DataRow("35724768011")]
        [DataRow("42413399054")]
        [DataRow("05601585059")]
        public void VerificaDocumentoCPF(string cpf)
        {
            var document = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(document.DocumentValidation(document));
            
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("49986735000125")]
        [DataRow("86676739000133")]
        [DataRow("20780936000190")]
        public void VerificaDocumentoCNPJ(string cnpj)
        {            
            var document = new Document(cnpj, EDocumentType.CNPJ);
            Assert.IsTrue(document.DocumentValidation(document));
            
        }
    }
}