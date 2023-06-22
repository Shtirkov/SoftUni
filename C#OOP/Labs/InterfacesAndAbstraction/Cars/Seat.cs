using Cars.Interfaces;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Start() => Constants.EngineStartMessage;

        public string Stop() => Constants.EngineStopMessage;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Color} {GetType().Name} {Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString();
        }
    }
}
