using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverExample;

namespace ObserverTests
{
    [TestClass]
    public class FuelPriceDisplayTests
    {
        [TestMethod]
        public void GetsPriceOnInstantiation()
        {
            //Arrange
            PricingManager manager = new PricingManager(1.00);
            //Act
            FuelPriceDisplay display = new FuelPriceDisplay(manager);
            //Assert
            Assert.AreEqual(1.0, display.FuelPrice);
        }

        [TestMethod]
        public void GetsNotifiedonFuelPriceChange()
        {
            //Arrange
            PricingManager manager = new PricingManager();
            FuelPriceDisplay display = new FuelPriceDisplay(manager);
            manager.AddObserver(display);
            //Act
            manager.UpdateFuelPrice(1.78);
            //Assert
            Assert.AreEqual(1.78, display.FuelPrice);
        }
    }
}
