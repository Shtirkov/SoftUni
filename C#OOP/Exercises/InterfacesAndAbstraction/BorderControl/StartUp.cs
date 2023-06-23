using BorderControl.Interfaces;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //04. Border control

            //var ids = new List<string>();
            //var fakeIds = new List<string>();

            //var input = Console.ReadLine();

            //while (input != "End")
            //{
            //    var data = input.Split();

            //    if (data.Length == 3)
            //    {
            //        ids.Add(data[2]);
            //    }
            //    else if (data.Length == 2)
            //    {
            //        ids.Add(data[1]);
            //    }

            //    input = Console.ReadLine();
            //}

            //var fakeIdsLastDigits = Console.ReadLine();

            //fakeIds = ids.Where(id => id.EndsWith(fakeIdsLastDigits)).ToList();
            //fakeIds.ForEach(id => Console.WriteLine(id));

            //05. Birthday celebrations

            //var allBirthdates = new List<string>();
            //var filteredBirthdates = new List<string>();

            //var input = Console.ReadLine();

            //while (input != "End")
            //{
            //    var data = input.Split();

            //    if (data[0] == "Citizen")
            //    {
            //        allBirthdates.Add(data[4]);
            //    }
            //    else if (data[0] == "Pet")
            //    {
            //        allBirthdates.Add(data[2]);
            //    }

            //    input = Console.ReadLine();
            //}

            //var yearForFiltering = Console.ReadLine();

            //filteredBirthdates = allBirthdates.Where(birthdate => birthdate.EndsWith(yearForFiltering)).ToList();
            //filteredBirthdates.ForEach(birthdate => Console.WriteLine(birthdate));

            //06. Food Shortage

            var numberOfPeople = int.Parse(Console.ReadLine());
            var buyers = new List<IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var data = Console.ReadLine().Split();

                if (data.Length == 3)
                {
                    buyers.Add(new Rebel(data[0], int.Parse(data[1]), data[2]));
                }
                else if (data.Length == 4)
                {
                    buyers.Add(new Citizen(data[0], int.Parse(data[1]), data[2], data[3]));
                }
            }

            var buyerName = Console.ReadLine();
            var totalFoodPurchased = 0;

            while (buyerName != "End")
            {
                var buyer = buyers.FirstOrDefault(buyer => buyer.Name == buyerName);

                if (buyer != null)
                {
                    totalFoodPurchased += buyer.BuyFood();
                }

                buyerName = Console.ReadLine();
            }

            Console.WriteLine(totalFoodPurchased);
        }
    }
}