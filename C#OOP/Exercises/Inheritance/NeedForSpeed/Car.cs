namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            base.FuelConsumption = 3;
        }

        public override double FuelConsumption { get => base.FuelConsumption; }
    }
}
