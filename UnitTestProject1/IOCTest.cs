using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InversionOfControl;
using Repository.Interface;
using Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

        [TestMethod]
        public void TestMethod2()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax");

            //Act
            var calculateTax = ioc.GetList<ICalculateTax>("CompanyATax").ToList();

            //Asert
            Assert.IsInstanceOfType(calculateTax.First(), typeof(CompanyATax));
        }

        [TestMethod]
        public void GetSingleByClassName()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax");

            //Act
            var calculateTax = ioc.GetSingleByClassName<ICalculateTax>("CompanyATax");

            //Asert
            Assert.IsInstanceOfType(calculateTax, typeof(CompanyATax));
        }

        [TestMethod]
        public void GetSingle()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax");

            //Act
            var calculateTax = ioc.GetSingleByClassName<ICalculateTax>();

            //Asert
            Assert.IsInstanceOfType(calculateTax, typeof(CompanyATax));
        }


    }
}
