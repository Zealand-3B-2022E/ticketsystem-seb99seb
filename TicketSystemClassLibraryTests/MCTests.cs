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
            double ExpectedValue = 125;
            MC mc = new MC("A7BH3AS");
            double ActualValue = mc.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void VehicleTypeTestSucess()
        {
            string ExpectedValue = "MC";
            MC mc = new MC("A7BH3AS");
            string ActualValue = mc.VehicleType();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void LicensePlateTestSuccess()
        {
            string ExpectedValue = "A7BH3AS";
            MC mc = new MC("A7BH3AS");
            string ActualValue = mc.LicensePlate;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
        "License Plate of more than not within 1-7 range of symbols are not allowed")]

        public void LicensePlateTestFail()
        {
            MC mc = new MC("A7BH3ASHJG");
        }
    }
}