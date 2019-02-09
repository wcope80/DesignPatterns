using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract class example
namespace CommandExample
{
    public class FuelTransfer : Command
    {
        private FuelTank _ReceivingTank { get; set; }
        private FuelTank _OriginatingTank { get; set; }
        public int _Amount { get; set; }

        public FuelTransfer(FuelTank originatingTank, FuelTank receivingTank, int amount)
        {
            _OriginatingTank = originatingTank;
            _ReceivingTank = receivingTank;
            _Amount = amount;
        }

        public override void Execute()
        {
            _ReceivingTank.FuelLevel += _Amount;
            _OriginatingTank.FuelLevel -= _Amount;
            IsComplete = true;
        }
    }
}
