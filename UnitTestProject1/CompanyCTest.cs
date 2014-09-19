using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InversionOfControl;
using Repository.Interface;
using Repository;

namespace UnitTestProject1
{
    [TestClass]
    public class CompanyCTest
    {

        [TestMethod]
        public void GetSingle_UK_GetsUKTax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("UKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("UK");

            //Asert
            Assert.IsInstanceOfType(item, typeof(UKTax));
        }

        [TestMethod]
        public void GetSingle_UK_GetsFranceTax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("UKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("France");

            //Asert
            Assert.IsInstanceOfType(item, typeof(FranceTax));
        }

        [TestMethod]
        public void GetSingle_UK_GetsUSATax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("UKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("USA");

            //Asert
            Assert.IsInstanceOfType(item, typeof(USATax));
        }



        [TestMethod]
        public void GetSingle_UK_GetsUKTax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("UKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("UK");
            item.Pay = 100;
            var value = item.CalculateTax();

            //Asert
            Assert.AreEqual(value, 60);
        }

        [TestMethod]
        public void GetSingle_UK_GetsFranceTax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("UKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("France");
            item.Pay = 100;
            var value = item.CalculateTax();

            //Asert
            Assert.AreEqual(value, 50);
        }

        [TestMethod]
        public void GetSingle_UK_GetsUSATax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("UKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("USA");
            item.Pay = 100;
            var value = item.CalculateTax();

            //Asert
            Assert.AreEqual(value, 70);
        }
    }
}
