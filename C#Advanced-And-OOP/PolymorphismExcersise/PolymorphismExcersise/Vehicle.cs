using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExcersise
{
 public   class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelConsumption = fuelConsumption;
            this.fuelQuantity = fuelQuantity;
        }

        private double fuelQuantity;
        private double fuelConsumption;
        
        public double FuelQuantity {
            get 
            {
                return this.fuelQuantity;
            }
            set
            {
                if (Vehicle == Truck)
                {

                }
            }
        }

        public double FuelConsumption { get; set; }

        public double Drive { get; set; }

        public double Refuel { get; set; }
    }
}
