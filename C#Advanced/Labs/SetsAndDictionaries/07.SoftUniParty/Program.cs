namespace _07.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guest = Console.ReadLine();
            var vipGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            while (guest != "PARTY")
            {
                if (char.IsDigit(guest[0]))
                {
                    vipGuests.Add(guest);
                }
                else
                {
                    regularGuests.Add(guest);
                }

                guest = Console.ReadLine();
            }

            guest = Console.ReadLine();

            while (guest != "END")
            {
                if (char.IsDigit(guest[0]))
                {
                    vipGuests.Remove(guest);
                }
                else
                {
                    regularGuests.Remove(guest);
                }

                guest = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            vipGuests.ToList().ForEach(x => Console.WriteLine(x));
            regularGuests.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}