using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MementoExample;

namespace MementoTests
{
    [TestClass]
    public class MementoTests
    {
        [TestMethod]
        public void TestRevert()
        {
            //Arrange
            TankHistory history = new TankHistory();
            FuelTank tank = new FuelTank() { FuelLevel = 100, FuelType = "Unleaded"};
            //act
            history.memento = tank.CreateMemento();
            tank.FuelLevel = 150;
            tank.FuelType = "Diesel";
            tank.RevertTank(history.memento);

            //assert
            Assert.AreEqual(100, tank.FuelLevel);
            Assert.AreEqual("Unleaded", tank.FuelType);
            
        }

        [TestMethod]
        public void TestMemento()
        {
            //Arrange
            TankHistory history = new TankHistory();
            FuelTank tank = new FuelTank() { FuelLevel = 100, FuelType = "Unleaded" };
            //act
            history.memento = tank.CreateMemento();
            //assert
            Assert.AreEqual(tank.FuelType, history.memento.FuelType);
            Assert.AreEqual(tank.FuelLevel, history.memento.FuelLevel);


        }
    }
}
