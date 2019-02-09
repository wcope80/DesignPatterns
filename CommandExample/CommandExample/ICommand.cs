using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public interface ICommand 
    {
        bool IsComplete { get; set; }
        void Execute();
    }
}
