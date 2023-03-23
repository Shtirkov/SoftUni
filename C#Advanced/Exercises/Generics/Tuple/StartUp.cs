namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var secondLine = Console.ReadLine().Split();
            var thirdLine = Console.ReadLine().Split();

            var firstTuple = new Threeuple<string, string, string>($"{firstLine[0]} {firstLine[1]}", firstLine[2], firstLine[3]);
            var secondTuple = new Threeuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]), secondLine[2] == "drunk" ? true : false);
            var thirdTuple = new Threeuple<string, double, string>(thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);

            Console.WriteLine($"{firstTuple.First} -> {firstTuple.Second} -> {firstTuple.Third}");
            Console.WriteLine($"{secondTuple.First} -> {secondTuple.Second} -> {secondTuple.Third}");
            Console.WriteLine($"{thirdTuple.First} -> {thirdTuple.Second} -> {thirdTuple.Third}");
        }
    }
}