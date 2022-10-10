using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class SBCarTests
    {
        [TestMethod()]
        public void PriceTestNoDiscount()
        {
            double ExpectedValue = 240;
            SBCar car = new SBCar("A7BH3AS");
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void PriceTestWithWeekendAndBrobizz()
        {
            double ExpectedValue = 182.4;
            SBCar car = new SBCar("A7BH3AS");
            car.Brobizz = true;
            car.Weekend = true;
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void PriceTestWithWeekend()
        {
            double ExpectedValue = 192;
            SBCar car = new SBCar("A7BH3AS");
            car.Weekend = true;
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void PriceTestWithBrobizz()
        {
            double ExpectedValue = 228;
            SBCar car = new SBCar("A7BH3AS");
            car.Brobizz = true;
            double ActualValue = car.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}