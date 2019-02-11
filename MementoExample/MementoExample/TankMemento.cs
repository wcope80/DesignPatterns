using System;

namespace MementoExample
{
    public class TankMemento
    {
        public string FuelType { get; set; }
        public int FuelLevel { get; set; }

        public TankMemento(FuelTank tank)
        {
            FuelType = tank.FuelType;
            FuelLevel = tank.FuelLevel;
        }

    }
}
