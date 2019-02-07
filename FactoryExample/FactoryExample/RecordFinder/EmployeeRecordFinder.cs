using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class EmployeeRecordFinder : RecordFinder
    {
        public override bool HasRecord { get; }
        public override string ResultString { get; }
        public override string BuildResultString()
        {
            return "Employee Record Finder";
        }
    }
}