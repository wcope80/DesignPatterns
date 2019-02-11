using System;
using System.Collections.Generic;
using System.Text;

namespace MementoExample
{
    
    public class FuelTank
    {
        public TankMemento Memento { get; set; }
        public string FuelType { get; set; }
        public int FuelLevel { get; set; }
        

        public TankMemento CreateMemento()
        {
            return new TankMemento(this);
        }

        public void RevertTank(TankMemento memento)
        {
            FuelType = memento.FuelType;
            FuelLevel = memento.FuelLevel;
        }

    }
    
}
