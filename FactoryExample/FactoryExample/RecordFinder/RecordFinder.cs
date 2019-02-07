using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public abstract class RecordFinder
    {
        public abstract bool HasRecord { get; }
        public abstract string ResultString { get; }
        public abstract string BuildResultString();        
    }
    
}
