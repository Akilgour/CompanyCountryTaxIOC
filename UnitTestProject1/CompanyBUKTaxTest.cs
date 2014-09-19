using InversionOfControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using Repository.Interface;


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

        [TestMethod]
        public void GetSingle_UK_GetsCompanyBUKTax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyBUKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("UK");

            //Asert
            Assert.IsInstanceOfType(item, typeof(CompanyBUKTax));
        }

        [TestMethod]
        public void GetSingle_UK_GetsFranceTax()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyBUKTax", "UK");
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
            ioc.Register<ICalculateTax>("CompanyBUKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("USA");

            //Asert
            Assert.IsInstanceOfType(item, typeof(USATax));
        }

        

        [TestMethod]
        public void GetSingle_UK_GetsCompanyBUKTax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyBUKTax", "UK");
            ioc.Register<ICalculateTax>("FranceTax", "France");
            ioc.Register<ICalculateTax>("USATax", "USA");

            //Act
            var item = ioc.GetSingleByCountry<ICalculateTax>("UK");
            item.Pay = 100;
            var value = item.CalculateTax();

            //Asert
            Assert.AreEqual(value, 90);
        }

        [TestMethod]
        public void GetSingle_UK_GetsFranceTax_Value()
        {
            //Arange
            var ioc = new IOC();
            ioc.Register<ICalculateTax>("CompanyBUKTax", "UK");
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
            ioc.Register<ICalculateTax>("CompanyBUKTax", "UK");
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
