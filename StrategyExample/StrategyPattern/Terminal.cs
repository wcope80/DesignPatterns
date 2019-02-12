using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    public class Terminal
    {
        private IBehavior Behavior;
        public Terminal(IBehavior behavior)
        {
            this.Behavior = behavior;
        }

        public string TurnOnPump()
        {
            return this.Behavior.TurnOnPump();
        }

    }
}
