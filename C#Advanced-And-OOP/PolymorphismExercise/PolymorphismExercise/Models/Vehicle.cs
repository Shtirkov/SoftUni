using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;

namespace Vehicles
{
    public abstract class Vehicle : IDrivable, IRefuable
    {
        private const string SuccessfullyTraveledKms = "{0} travelled {1} km";
        private double tankCapacity = 0;
        private double fuelQuantity = 0;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public virtual double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            private set
            {
                if (tankCapacity < value)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumption { get; private set; }

        public virtual double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                tankCapacity = value;
            }
        }

        public string Drive(double distance)
        {
            if (FuelConsumption * distance > FuelQuantity)
            {               
                throw new InvalidOperationException(string.Format(Exceptions.NotEnoughFuelExceptionMsg, this.GetType().Name));
            }
            FuelQuantity -= distance * FuelConsumption;
            return string.Format(SuccessfullyTraveledKms, this.GetType().Name, distance);
        }

        public virtual void Refuel(double amount)
        {
            if (this.FuelQuantity + amount > tankCapacity)
            {
                if (this.GetType().Name == "Truck")
                {
                    return;
                }
                throw new InvalidOperationException(string.Format(Exceptions.CannotFitFuelAmountExceptionMsg, amount));
            }
            else if (amount <= 0)
            {
                throw new InvalidOperationException(Exceptions.NegativeFuelExceptionMsg);
            }
            this.FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
