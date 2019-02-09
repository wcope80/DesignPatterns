using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface example
namespace CommandExample
{
    public class FuelReceipt : ICommand
    {
        private FuelTank _fuelTank;
        private int _amount;

        public FuelReceipt(FuelTank fuelTank, int amount)
        {
            _fuelTank = fuelTank;
            _amount = amount;
        }
        public bool IsComplete { get; set; }

        public void Execute()
        {
            _fuelTank.FuelLevel = _fuelTank.FuelLevel + _amount;
            IsComplete = true;
        }
    }
}
