using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
 

namespace UnitTestProject1
{
    [TestClass]
    public class CompanyATaxTest
    {
        [TestMethod]
        public void CalculateTax_AreEqual()
        {
            //Arange
            var company = new CompanyATax(100); 

            //Act
            var value = company.CalculateTax();

            //Assert
            Assert.AreEqual(value, 100);

        }
    }
}
