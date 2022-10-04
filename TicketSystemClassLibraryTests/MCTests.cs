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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            MC mc = new MC();
            double ActualValue = mc.Price();
            double ExpectedValue = 125;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void VehicleTypeTestSucess()
        {
            MC mc = new MC();
            string ActualValue = mc.VehicleType();
            string ExpectedValue = "MC";
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}