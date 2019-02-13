using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    public interface IObserver
    {
        void Notify();
    }
}
