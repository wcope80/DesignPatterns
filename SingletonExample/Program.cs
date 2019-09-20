using System;
using System.Threading;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Lock
            ValueHolder timer1 = ValueHolder.Instance;
            timer1.SetValue(1);
            Console.WriteLine(timer1.GetValue()); 

            var timer2 = ValueHolder.Instance;
            Console.WriteLine(timer2.GetValue());

            //Better  Test Actual Threading
            ThreadedTimer tTimer1 = ThreadedTimer.Instance;
            tTimer1.StartTimer();
            Thread.Sleep(1000);
            ThreadedTimer tTimer2 = ThreadedTimer.Instance;
            tTimer1.StopTimer();
            Console.WriteLine(tTimer1.GetFinalTime());
            Thread.Sleep(200);
            Console.WriteLine(tTimer2.GetFinalTime());
            

            Console.ReadLine();
        }
    }
}
