namespace _10.PartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var inputArr = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            while (inputArr[0] != "Print")
            {
                var command = inputArr[0];
                var filterType = inputArr[1];
                var condition = inputArr[2];

                if (command == "Add filter")
                {
                    guests = FilterGuests(guests, filterType, condition, AddFilter);
                }
                else if (command == "Remove filter")
                {
                   guests = FilterGuests(guests, filterType, condition, RemoveFilter);
                }

                inputArr = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", guests));
        }

        private static List<string> _removedGuests = new List<string>();

        private static List<string> FilterGuests(List<string> guests, string filterType, string condition, Func<List<string>, string, string, List<string>> filteringFunc)
            => filteringFunc(guests, filterType, condition);

        private static List<string> AddFilter(List<string> guests, string filterType, string condition)
        {
            switch (filterType)
            {
                case "Starts with":
                    guests.Where(x => x.StartsWith(condition)).ToList().ForEach(x => _removedGuests.Add(x));
                    return guests.Where(x => !x.StartsWith(condition)).ToList();
                case "Ends with":
                    guests.Where(x => x.EndsWith(condition)).ToList().ForEach(x => _removedGuests.Add(x));
                    return guests.Where(x => !x.EndsWith(condition)).ToList();
                case "Length":
                    guests.Where(x => x.Length == int.Parse(condition)).ToList().ForEach(x => _removedGuests.Add(x));
                    return guests.Where(x => x.Length != int.Parse(condition)).ToList();
                case "Contains":
                    guests.Where(x => x.Contains(condition)).ToList().ForEach(x => _removedGuests.Add(x));
                    return guests.Where(x => !x.Contains(condition)).ToList();
                default:
                    return null;
            }
        }

        private static List<string> RemoveFilter(List<string> guests, string filterType, string condition)
        {
            var guestsThatAreBackIntoTheGuestsList = new List<string>();

            switch (filterType)
            {
                case "Starts with":
                    _removedGuests.ForEach(x =>
                    {
                        if (x.StartsWith(condition))
                        {
                            guests.Add(x);
                            guestsThatAreBackIntoTheGuestsList.Add(x);
                        }
                    });
                    guestsThatAreBackIntoTheGuestsList.ForEach(x => _removedGuests.Remove(x));
                    return guests;
                case "Ends with":
                    _removedGuests.ForEach(x =>
                    {
                        if (x.EndsWith(condition))
                        {
                            guests.Add(x);
                            guestsThatAreBackIntoTheGuestsList.Add(x);
                        }
                    });
                    guestsThatAreBackIntoTheGuestsList.ForEach(x => _removedGuests.Remove(x));
                    return guests;
                case "Length":
                    _removedGuests.ForEach(x =>
                    {
                        if (x.Length == int.Parse(condition))
                        {
                            guests.Add(x);
                            guestsThatAreBackIntoTheGuestsList.Add(x);
                        }
                    });
                    guestsThatAreBackIntoTheGuestsList.ForEach(x => _removedGuests.Remove(x));
                    return guests;
                case "Contains":
                    _removedGuests.ForEach(x =>
                    {
                        if (x.Contains(condition))
                        {
                            guests.Add(x);
                            guestsThatAreBackIntoTheGuestsList.Add(x);
                        }
                    });
                    guestsThatAreBackIntoTheGuestsList.ForEach(x => _removedGuests.Remove(x));
                    return guests;
                default:
                    return null;
            }
        }
    }
}