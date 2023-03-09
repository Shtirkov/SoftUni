namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var family = new Family();
            var familyMembersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < familyMembersCount; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                family.AddMember(new Person(name,age));
            }

            var oldestFamilyMember = family.GetOldestMember();
            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
         }
    }
}