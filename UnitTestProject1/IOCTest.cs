using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InversionOfControl;
using Repository.Interface;

namespace UnitTestProject1
{
    [TestClass]
    public class IOCTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            var ioc = new IOC();

            //Act
            ioc.Register<ICalculateTax>("CompanyATax");

            //Asert
            Assert.AreEqual(ioc.Items.Count, 1);

        }
    }
}
