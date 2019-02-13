using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    public class FuelPriceDisplay : IObserver
    {
        public double FuelPrice { get; set; }

        public PricingManager PricingManager;

        public FuelPriceDisplay(PricingManager pricingManager)
        {
            this.PricingManager = pricingManager;
            this.FuelPrice = this.PricingManager.FuelPrice;
        }

        public void Notify()
        {
            FuelPrice = PricingManager.FuelPrice;
        }
    }
}
