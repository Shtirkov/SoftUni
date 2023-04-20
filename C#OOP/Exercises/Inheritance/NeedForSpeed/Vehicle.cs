namespace NeedForSpeed
{
    public class Vehicle
    {
        private double _defaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;            
        }

        public virtual double FuelConsumption  { get => _defaultFuelConsumption; set => _defaultFuelConsumption = value; }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers) => Fuel -= kilometers * FuelConsumption;
    }
}
