using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    public class CarWashBehavior : IBehavior
    {
        public string TurnOnPump()
        {
            return "Turning on Car Wash.";
        }
    }
}
