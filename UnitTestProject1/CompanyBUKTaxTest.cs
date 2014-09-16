using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;


namespace UnitTestProject1
{
    [TestClass]
    public class CompanyBUKTaxTest
    {
        [TestMethod]
        public void CalculateTax_AreEqual()
        {
            //Arange
            var company = new CompanyBUKTax(100); 

            //Act
            var value = company.CalculateTax();

            //Assert
            Assert.AreEqual(value, 90);

        }
    }
}
