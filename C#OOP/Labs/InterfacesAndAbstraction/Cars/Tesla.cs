using Cars.Interfaces;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public Tesla(string model, string color, int batteriesCount)
        {
            Model = model;
            Color = color;
            Battery = batteriesCount;
        }

        public string Start() => Constants.EngineStartMessage;

        public string Stop() => Constants.EngineStopMessage;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Color} {GetType().Name} {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString();
        }

    }
}
