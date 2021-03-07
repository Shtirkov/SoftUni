using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private bool isBusEmpty = false;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                if (isBusEmpty == true)
                {
                    return base.FuelConsumption;
                }
                else
                {
                    return base.FuelConsumption + 1.4;
                }
            }
        }

        public void TurnAcOff()
        {
            isBusEmpty = true;
        }

        public void TurnAcOn()
        {
            isBusEmpty = false;
        }

    }
}
