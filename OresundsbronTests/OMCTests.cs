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
    public class OMCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            double ExpectedValue = 210;
            OMC MC = new OMC("A7BH3AS");
            double ActualValue = MC.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void PriceTestBrobizz()
        {
            double ExpectedValue = 73;
            OMC MC = new OMC("A7BH3AS");
            MC.Brobizz = true;
            double ActualValue = MC.Price();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [TestMethod()]
        public void VehicleTypeTest()
        {
            string ExpectedValue = "Oresund MC";
            OMC MC = new OMC("A7BH3AS");
            string ActualValue = MC.VehicleType();
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}