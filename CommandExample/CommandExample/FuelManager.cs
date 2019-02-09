using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class FuelManager
    {
        public List<ICommand> Commands = new List<ICommand>();

        public void ExecuteCommands()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }

        public bool HasPendingCommands()
        {
            return Commands.Where(c => !c.IsComplete).Any();
        }
    }
}
