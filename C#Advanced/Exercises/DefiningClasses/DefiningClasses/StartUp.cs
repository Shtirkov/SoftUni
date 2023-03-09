namespace People
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                people.Add(new Person { Name = name,Age = age });
            }

            people = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            people.ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}