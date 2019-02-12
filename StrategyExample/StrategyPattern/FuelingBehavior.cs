using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    public class FuelingBehavior : IBehavior
    {
        public string TurnOnPump()
        {
            return "Turning on Fuel Pump";
        }
    }
}
