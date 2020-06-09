using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductApp.Core;
using ProductApp.Infrastructure;

namespace ProductApp.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository Repo;
        [TestInitialize]
        public void TestSetup()
        {
            //AppDbContextExtensions db = new AppDbContextExtensions();
            Database.SetInitializer(new AppDbContextExtensions());
            Repo = new ProductRepository();
        }
        [TestMethod]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
          var result = Repo.GetProducts();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }
    }
}
