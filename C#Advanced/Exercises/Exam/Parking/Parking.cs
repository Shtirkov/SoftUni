using System.Text;

namespace Parking
{
    public class Parking
    {
        private readonly List<Car> _cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            _cars = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count { get => _cars.Count; }

        public void Add(Car car)
        {
            if (_cars.Count < Capacity)
            {
                _cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            for (int i = 0; i < _cars.Count; i++)
            {
                if (_cars[i].Manufacturer == manufacturer && _cars[i].Model == model)
                {
                    _cars.Remove(_cars[i]);
                    return true;
                }
            }

            return false;
        }

        public Car? GetLatestCar() => _cars.OrderByDescending(car => car.Year).FirstOrDefault();

        public Car? GetCar(string manufacturer, string model)
        {
            for (int i = 0; i < _cars.Count; i++)
            {
                if (_cars[i].Manufacturer == manufacturer && _cars[i].Model == model)
                {
                    return _cars[i];
                }
            }

            return null;
        }

        public string GetStatistics()
        {
            var output = new StringBuilder();

            output.AppendLine($"The cars are parked in {Type}:");
            _cars.ForEach(car => output.AppendLine(car.ToString()));
            return output.ToString();
        }
    }
}
