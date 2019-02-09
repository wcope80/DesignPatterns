using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandExample;

namespace CommandTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReceiptAddsFuel()
        {
            //Arrange
            FuelTank tank = new FuelTank("Unleaded", 1000);
            ICommand receipt = new FuelReceipt(tank, 500);
            //Act
            receipt.Execute();
            //Assert
            Assert.AreEqual(tank.FuelLevel, 1500);
        }

        [TestMethod]
        public void FuelTransferAddsFuel()
        {
            //Arrange
            FuelTank origTank = new FuelTank("Unleaded", 1000);
            FuelTank recTank = new FuelTank("Unleaded", 1000);
            Command transfer = new FuelTransfer(origTank, recTank, 500);
            //Act
            transfer.Execute();
            //Assert
            Assert.AreEqual(1500, recTank.FuelLevel);
        }

        [TestMethod]
        public void FuelTransferSubtractsFuel()
        {
            // Arrange
            FuelTank origTank = new FuelTank("Unleaded", 1000);
            FuelTank recTank = new FuelTank("Unleaded", 1000);
            Command transfer = new FuelTransfer(origTank, recTank, 500);
            //Act
            transfer.Execute();
            //Assert
            Assert.AreEqual(500, origTank.FuelLevel);
        }

        [TestMethod]
        public void ManagerHasPending()
        {
            //arrange
            FuelManager manager = new FuelManager();
            FuelTank tank = new FuelTank("Unl", 1000);
            FuelReceipt reciept = new FuelReceipt(tank, 100);            
            manager.Commands.Add(reciept);
            //act

            //assert
            Assert.AreEqual(true, manager.HasPendingCommands());

        }

        [TestMethod]
        public void ManagerHasNoPending()
        {
            //arrange
            FuelManager manager = new FuelManager();
            FuelTank tank = new FuelTank("Unl", 1000);
            FuelReceipt reciept = new FuelReceipt(tank, 100);
            manager.Commands.Add(reciept);
            //act
            manager.ExecuteCommands();
            //assert
            Assert.AreEqual(false, manager.HasPendingCommands());

        }
    }
}
