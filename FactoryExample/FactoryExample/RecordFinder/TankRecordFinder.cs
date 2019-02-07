using System;

namespace FactoryExample
{

    public class TankRecordFinder : RecordFinder
    {
        public override bool HasRecord { get; }
        public override string ResultString { get; }
        public override string BuildResultString()
        {
            return "Tank Record Finder";
        }
    }

}
