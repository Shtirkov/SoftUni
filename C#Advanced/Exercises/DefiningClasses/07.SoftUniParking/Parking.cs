using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private int _capacity;

        public Parking(int capacity)
        {
            Cars = new Dictionary<string, Car>();
            _capacity = capacity;
        }

        public Dictionary<string, Car> Cars { get; set; }

        public int Count => Cars.Count;

        public string AddCar(Car car)
        {
            if (Cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (Cars.Count == _capacity)
            {
                return "Parking is full!";
            }           

            Cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!Cars.ContainsKey(registrationNumber))
            {                
                return "Car with that registration number, doesn't exist!";
            }

            Cars.Remove(registrationNumber);
            return $"Successfully removed {registrationNumber}";
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            registrationNumbers.ForEach(r =>
            {
                if (Cars.ContainsKey(r))
                {
                    Cars.Remove(r);
                }
            });
        }       

        public Car GetCar(string registrationNumber) => Cars.Values.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
    }
}
