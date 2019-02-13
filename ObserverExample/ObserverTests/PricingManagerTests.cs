using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverExample;

namespace ObserverTests
{
    [TestClass]
    public class PricingManagerTests
    {
        [TestMethod]
        public void AddObserverAddsObserver()
        {
            //Arrange
            PricingManager manager = new PricingManager();
            FuelPriceDisplay display = new FuelPriceDisplay(manager);
            //Act
            manager.AddObserver(display);
            //Assert
            Assert.AreEqual(1, manager.Observers.Count);
        }

        [TestMethod]
        public void RemoveObserverRemovesObserver()
        {
            //Arrange
            PricingManager manager = new PricingManager();
            FuelPriceDisplay display = new FuelPriceDisplay(manager);
            Terminal terminal = new Terminal(manager);
            //Act
            manager.AddObserver(display);
            manager.AddObserver(terminal);
            manager.RemoveObserver(display);
            //Assert
            Assert.AreEqual(1, manager.Observers.Count);
        }
    }
}
