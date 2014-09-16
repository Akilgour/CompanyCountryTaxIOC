using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

namespace UnitTestProject1
{
    [TestClass]
    public class UKTaxTest
    {
        [TestMethod]
        public void CalculateTax_AreEqual()
        {
            //Arange
            var company = new UKTax(100);

            //Act
            var value = company.CalculateTax();

            //Assert
            Assert.AreEqual(value, 60);

        }
    }
}
