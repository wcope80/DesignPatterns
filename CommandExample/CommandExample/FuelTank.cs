using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class FuelTank
    {
        private string FuelType { get; set; }
        public int FuelLevel { get; set; }

        public FuelTank(string fuelType, int fuelLevel)
        {
            FuelType = fuelType;
            FuelLevel = fuelLevel;
        }
        
    }
}
