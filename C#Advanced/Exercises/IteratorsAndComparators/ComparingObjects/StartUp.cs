namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var people = new List<Person>();

            while (input != "END")
            {
                var info = input.Split();

                var name = info[0];
                var age = int.Parse(info[1]);
                var town = info[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }

            var indexOfPersonForComparison = int.Parse(Console.ReadLine()) - 1;
            var personForComparison = people[indexOfPersonForComparison];

            var matches = 0;

            people.ForEach(person =>
            {
                if (personForComparison.CompareTo(person) == 0)
                {
                    matches++;
                }
            });

            if (matches > 1)
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}