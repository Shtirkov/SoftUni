using System.Text;

namespace _06.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carsInTheParkingLot = new HashSet<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var inOrOut = input.Split(", ")[0];
                var carNumber = input.Split(", ")[1];

                if (inOrOut == "IN")
                {
                    carsInTheParkingLot.Add(carNumber);
                }
                else
                {
                    carsInTheParkingLot.Remove(carNumber);
                }

                input = Console.ReadLine();
            }
            
            if (carsInTheParkingLot.Count > 0)
            {
                carsInTheParkingLot.ToList().ForEach(car => Console.WriteLine(car));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}