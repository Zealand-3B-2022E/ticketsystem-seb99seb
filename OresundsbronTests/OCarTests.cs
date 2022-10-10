using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundsbron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundsbron.Tests
{
    [TestClass()]
    public class OCarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            double ExpectedValue = 410;
            OCar car = new OCar("A7BH3AS");
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void PriceTestBrobizz()
        {
            double ExpectedValue = 161;
            OCar car = new OCar("A7BH3AS");
            car.Brobizz = true;
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void VehicleTypeTest()
        {
            string ExpectedValue = "Oresund car";
            OCar car = new OCar("A7BH3AS");
            string ActualValue = car.VehicleType();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}