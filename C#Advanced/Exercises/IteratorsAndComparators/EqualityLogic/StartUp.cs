namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           var numberOfPeople = int.Parse(Console.ReadLine());

            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var info = Console.ReadLine().Split();

                var name = info[0];
                var age = int.Parse(info[1]);
                var person = new Person(name, age);

                sortedSet.Add(person);
                hashSet.Add(person);                
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}