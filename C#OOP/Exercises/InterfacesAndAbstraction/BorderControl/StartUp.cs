namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var allBirthdates = new List<string>();
            var filteredBirthdates = new List<string>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var data = input.Split();

                if (data[0] == "Citizen")
                {
                    allBirthdates.Add(data[4]);
                }
                else if (data[0] == "Pet")
                {
                    allBirthdates.Add(data[2]);
                }

                input = Console.ReadLine();
            }

            var yearForFiltering = Console.ReadLine();

            filteredBirthdates = allBirthdates.Where(birthdate => birthdate.EndsWith(yearForFiltering)).ToList();
            filteredBirthdates.ForEach(birthdate => Console.WriteLine(birthdate));
        }
    }
}