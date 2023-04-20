namespace NeedForSpeed
{
    public class Vehicle
    {
        private readonly double _defaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;            
        }

        public virtual double FuelConsumption  { get => _defaultFuelConsumption; }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers) => Fuel -= kilometers * FuelConsumption;
    }
}
