using System;
using System.Collections.Generic;

namespace FactoryExample
{
    static class RecordFinderFactory
    {

        public static RecordFinder GetFinder(string type)
        {
            switch (type)
            {
                case "Employee":
                    return new EmployeeRecordFinder();
                case "Tank":
                    return new TankRecordFinder();
                default:
                    return new EmployeeRecordFinder();
            }
        }

        public static RecordFinder GetFinder(FinderType type)
        {
            switch (type)
            {
                case FinderType.Employee:
                    return new EmployeeRecordFinder();
                case FinderType.Tank:
                    return new TankRecordFinder();
                default:
                    return new EmployeeRecordFinder();
            }
        }
    }

    //    public static RecordFinder GetFinder(object obj)
    //    {
    //        library lib = new library();

    //        switch (lib.typeDict[obj.GetType()])
    //        {
    //            case lib.typeDict[typeof(Employee)]:
    //                return new EmployeeRecordFinder();
    //            case lib.typeDict[typeof(Tank)]:
    //                return new TankRecordFinder();
    //            default:
    //                return new EmployeeRecordFinder();
    //        }
    //    }

    //}

    public enum FinderType
    {
        Employee,
        Tank
    }

    //public class library
    //{
    //    public readonly Dictionary<Type, int> typeDict = new Dictionary<Type, int>
    //    {
    //        { typeof(Employee), 0},
    //        { typeof(Tank), 1}

    //    };
    //}

}


