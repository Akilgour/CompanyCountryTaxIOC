using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using InversionOfControl;
using Repository.Interface;
 

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

        [TestMethod]
        public void GetSingle_UK_GetsCompanyATax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax", "UK");
            ioc.Register<ICalculateTax>("CompanyATax", "France");
            ioc.Register<ICalculateTax>("CompanyATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("UK");

            //Asert
            Assert.IsInstanceOfType(item, typeof(CompanyATax));
        }

        [TestMethod]
        public void GetSingle_UK_GetsCompanyATax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax", "UK");
            ioc.Register<ICalculateTax>("CompanyATax", "France");
            ioc.Register<ICalculateTax>("CompanyATax", "USA");
  
            var item = ioc.GetSingleByCountry<ICalculateTax>("UK");
            item.Pay = 100;

            //Act
            var value = item.CalculateTax();

            //Assert
            Assert.AreEqual(value, 100);
        }

        [TestMethod]
        public void GetSingle_France_GetsCompanyATax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax", "UK");
            ioc.Register<ICalculateTax>("CompanyATax", "France");
            ioc.Register<ICalculateTax>("CompanyATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("France");

            //Asert
            Assert.IsInstanceOfType(item, typeof(CompanyATax));
        }

        [TestMethod]
        public void GetSingle_France_GetsCompanyATax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax", "UK");
            ioc.Register<ICalculateTax>("CompanyATax", "France");
            ioc.Register<ICalculateTax>("CompanyATax", "USA");

            var item = ioc.GetSingleByCountry<ICalculateTax>("France");
            item.Pay = 100;

            //Act
            var value = item.CalculateTax();

            //Assert
            Assert.AreEqual(value, 100);
        }

        [TestMethod]
        public void GetSingle_USA_GetsCompanyATax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax", "UK");
            ioc.Register<ICalculateTax>("CompanyATax", "France");
            ioc.Register<ICalculateTax>("CompanyATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("USA");

            //Asert
            Assert.IsInstanceOfType(item, typeof(CompanyATax));
        }

        [TestMethod]
        public void GetSingle_USA_GetsCompanyATax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyATax", "UK");
            ioc.Register<ICalculateTax>("CompanyATax", "France");
            ioc.Register<ICalculateTax>("CompanyATax", "USA");

            var item = ioc.GetSingleByCountry<ICalculateTax>("USA");
            item.Pay = 100;

            //Act
            var value = item.CalculateTax();

            //Assert
            Assert.AreEqual(value, 100);
        }
    }
}
