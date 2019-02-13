using System;
using System.Collections.Generic;

namespace ObserverExample
{
    public class PricingManager : IObservable
    {
        public List<IObserver> Observers = new List<IObserver>();
        public double FuelPrice { get; private set; }

        public PricingManager() { }

        public PricingManager(double fuelPrice)
        {
            this.FuelPrice = fuelPrice;
        }

        public void AddObserver(IObserver observer)
        {
            if (!this.Observers.Contains(observer))
                this.Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (this.Observers.Contains(observer))
                this.Observers.Remove(observer);
        }

        public void UpdateObservers()
        {
            foreach (IObserver observer in Observers)
            {                
                observer.Notify();
            }
        }

        public void UpdateFuelPrice(double newPrice)
        {
            if (this.FuelPrice != newPrice)
            {
                this.FuelPrice = newPrice;
                UpdateObservers();
            }
        }

    }
}
