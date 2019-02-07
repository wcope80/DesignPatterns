using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RecordFinder rffString = RecordFinderFactory.GetFinder("Employee");
            Console.WriteLine(rffString.GetType().ToString());

            RecordFinder rffEnum = RecordFinderFactory.GetFinder(FinderType.Tank);
            Console.WriteLine(rffEnum.GetType().ToString());

            Console.ReadLine();
        }
    }
}
