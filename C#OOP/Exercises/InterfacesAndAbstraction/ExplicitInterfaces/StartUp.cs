using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                var data = input.Split();

                var name = data[0];
                var country = data[1];
                var age = int.Parse(data[2]);

                var person = new Citizen(name, country, age);
                IPerson p = person;
                IResident r = person;

                Console.WriteLine(p.GetName());
                Console.WriteLine(r.GetName());

                input = Console.ReadLine();
            }
        }
    }
}