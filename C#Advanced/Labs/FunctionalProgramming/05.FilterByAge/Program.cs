namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < peopleCount; i++)
            {
                var personArray = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var name = personArray[0];
                var age = int.Parse(personArray[1]);

                _ = people.TryGetValue(name, out int value) ? people[name] = age : people[name] = age;
            }

            var condition = Console.ReadLine();
            var ageFilter = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<Dictionary<string, int>, int, Dictionary<string, int>> filterFunction = SelectFilterFunction(condition);
            people = FilterPeople(people, ageFilter, filterFunction);

            Action<Dictionary<string, int>, string> printer = PrintPeople;
            printer.Invoke(people, format);
        }

        private static Dictionary<string, int> FilterPeople(Dictionary<string, int> people, int age, Func<Dictionary<string, int>, int, Dictionary<string, int>> filterFunction)
            => filterFunction(people, age);

        private static Dictionary<string, int> FilterYoungerThanSpecifiedAge(Dictionary<string, int> people, int age)
            => people.Where(x => x.Value < age).ToDictionary(x => x.Key, y => y.Value);

        private static Dictionary<string, int> FilterOlderThanSpecifiedAge(Dictionary<string, int> people, int age)
           => people.Where(x => x.Value >= age).ToDictionary(x => x.Key, y => y.Value);

        private static Func<Dictionary<string, int>, int, Dictionary<string, int>> SelectFilterFunction(string condition) =>
            condition == "younger" ? FilterYoungerThanSpecifiedAge : FilterOlderThanSpecifiedAge;

        private static void PrintPeople(Dictionary<string, int> people, string format)
        {
            switch (format)
            {
                case "name":
                    people.Keys.ToList().ForEach(x => Console.WriteLine(x));
                    break;
                case "age":
                    people.Values.ToList().ForEach(x => Console.WriteLine(x));
                    break;
                case "name age":
                    foreach (var person in people)
                    {
                        Console.WriteLine($"{person.Key} - {person.Value}");
                    }
                    break;
            }
        }
    }
}