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
            double ExpectedValue = 240;
            Car car = new Car("A7BH3AS");
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue,ActualValue);
        }
        [TestMethod()]
        public void PriceTestDiscount()
        {
            double ExpectedValue = 228;
            Car car = new Car("A7BH3AS");
            car.Brobizz = true;
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [TestMethod()]
        public void VehicleTypeTestSucess()
        {
            string ExpectedValue = "Car";
            Car car = new Car("A7BH3AS");
            string ActualValue = car.VehicleType();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void LicensePlateTestSuccess()
        {
            string ExpectedValue = "A7BH3AS";
            Car car = new Car("A7BH3AS");
            string ActualValue = car.LicensePlate;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
        "License Plate of more than not within 1-7 range of symbols are not allowed")]

        public void LicensePlateTestFail()
        {
            Car car = new Car("A7BH3ASHJG");
        }
    }
}