using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverExample;

namespace ObserverTests
{
    [TestClass]
    public class TerminalTests
    {
        [TestMethod]
        public void GetsPriceOnInstantiation()
        {
            //Arrange
            PricingManager manager = new PricingManager(1.00);
            //Act
            Terminal terminal = new Terminal(manager);           
            //Assert
            Assert.AreEqual(1.0, terminal.FuelPrice);
        }

        [TestMethod]
        public void GetsNotifiedonFuelPriceChange()
        {
            //Arrange
            PricingManager manager = new PricingManager();
            Terminal terminal = new Terminal(manager);
            manager.AddObserver(terminal);
            //Act
            manager.UpdateFuelPrice(1.78);
            //Assert
            Assert.AreEqual(1.78, terminal.FuelPrice);
        }

    }
}
