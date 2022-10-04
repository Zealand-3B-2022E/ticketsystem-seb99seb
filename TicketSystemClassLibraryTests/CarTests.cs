using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Car car = new Car();
            double ActualValue = car.Price();
            double ExpectedValue = 240;
            Assert.AreEqual(ExpectedValue,ActualValue);
        }

        [TestMethod()]
        public void VehicleTypeTestSucess()
        {
            Car car = new Car();
            string ActualValue = car.VehicleType();
            string ExpectedValue = "Car";
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}