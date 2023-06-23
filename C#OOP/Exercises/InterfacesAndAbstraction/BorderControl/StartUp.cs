namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var ids = new List<string>();
            var fakeIds = new List<string>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var data = input.Split();

                if (data.Length == 3)
                {
                    ids.Add(data[2]);
                }
                else if (data.Length == 2)
                {
                    ids.Add(data[1]);
                }

                input = Console.ReadLine();
            }

            var fakeIdsLastDigits = Console.ReadLine();

            fakeIds = ids.Where(id => id.EndsWith(fakeIdsLastDigits)).ToList();
            fakeIds.ForEach(id => Console.WriteLine(id));
        }
    }
}