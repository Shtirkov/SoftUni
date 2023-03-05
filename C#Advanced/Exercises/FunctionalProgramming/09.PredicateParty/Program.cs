namespace _09.PredicateParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var input = Console.ReadLine();

            while (input != "Party!")
            {
                var inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = inputArr[0];
                var firstCondition = inputArr[1];
                var secondCondition = inputArr[2];

                if (command == "Remove")
                {
                    if (firstCondition == "StartsWith")
                    {
                        people = PrepareTheGuestsList(people, secondCondition, RemoveStartingWith);
                    }
                    else if (firstCondition == "EndsWith")
                    {
                        people = PrepareTheGuestsList(people, secondCondition, RemoveEndingWith);
                    }
                    else if (firstCondition == "Length")
                    {
                        people = PrepareTheGuestsList(people, secondCondition, RemovePeopleWithNameLength);
                    }
                }
                else if (command == "Double")
                {
                    if (firstCondition == "StartsWith")
                    {
                        people = PrepareTheGuestsList(people, secondCondition, DoubleStartingWith);
                    }
                    else if (firstCondition == "EndsWith")
                    {
                        people = PrepareTheGuestsList(people, secondCondition, DoubleEndingWith);
                    }
                    else if (firstCondition == "Length")
                    {
                        people = PrepareTheGuestsList(people, secondCondition, DoublePeopleWithNameLength);
                    }
                }

                input = Console.ReadLine();
            }

            var output = people.Any() ? $"{string.Join(", ", people)} are going to the party!" : "Nobody is going to the party!";
            Console.WriteLine(output);
        }

        private static List<string> PrepareTheGuestsList(List<string> guests, string condition, Func<List<string>, string, List<string>> prepareFunc)
            => prepareFunc(guests, condition);

        private static List<string> RemoveStartingWith(List<string> guests, string startsWith)
            => guests = guests.Where(x => !x.StartsWith(startsWith)).ToList();

        private static List<string> RemoveEndingWith(List<string> guests, string endsWith)
            => guests = guests.Where(x => !x.EndsWith(endsWith)).ToList();

        private static List<string> RemovePeopleWithNameLength(List<string> guests, string nameLength)
            => guests = guests.Where(x => x.Length != int.Parse(nameLength)).ToList();

        private static List<string> DoubleStartingWith(List<string> guests, string startsWith)
        {
            var modifiedList = new List<string>();
            guests.ForEach(x =>
            {
                modifiedList.Add(x);

                if (x.StartsWith(startsWith))
                {
                    modifiedList.Add(x);
                }
            });

            return modifiedList;
        }

        private static List<string> DoubleEndingWith(List<string> guests, string endsWith)
        {
            var modifiedList = new List<string>();
            guests.ForEach(x =>
            {
                modifiedList.Add(x);

                if (x.EndsWith(endsWith))
                {
                    modifiedList.Add(x);
                }
            });

            return modifiedList;
        }

        private static List<string> DoublePeopleWithNameLength(List<string> guests, string nameLength)
        {
            var modifiedList = new List<string>();
            guests.ForEach(x =>
            {
                modifiedList.Add(x);

                if (x.Length == int.Parse(nameLength))
                {
                    modifiedList.Add(x);
                }
            });

            return modifiedList;
        }
    }
}