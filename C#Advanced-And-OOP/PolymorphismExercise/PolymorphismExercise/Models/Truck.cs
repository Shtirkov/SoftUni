using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double FuelConsumptionIncrement = 1.6;
        private const double AmountOfRefueledFuel = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + FuelConsumptionIncrement;

        public override void Refuel(double amount)
        {
            if (amount > base.TankCapacity)
            {
                throw new InvalidOperationException(string.Format(Exceptions.CannotFitFuelAmountExceptionMsg, amount));
            }
          base.Refuel(amount * AmountOfRefueledFuel);
        }

    }
}
