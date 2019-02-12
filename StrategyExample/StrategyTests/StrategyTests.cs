using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyExample;

namespace StrategyTests
{
    [TestClass]
    public class StrategyTests
    {
        [TestMethod]
        public void FuelingTerminalFuels()
        {
            //Arrange
            Terminal terminal = new Terminal(new FuelingBehavior());
            //Act 
            string behaviorResult = terminal.TurnOnPump();
            //Assert
            Assert.AreEqual("Turning on Fuel Pump", behaviorResult);
        }

        [TestMethod]
        public void CarWashTerminalCarWashes()
        {
            //Arrange
            Terminal terminal = new Terminal(new CarWashBehavior());
            //Act
            string behaviorResult = terminal.TurnOnPump();
            //Assert
            Assert.AreEqual("Turning on Car Wash.", behaviorResult);
        }
    }
}
