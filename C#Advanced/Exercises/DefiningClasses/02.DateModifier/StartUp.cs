namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var dateModifier = new DateModifier();
            dateModifier.CalculateDaysDifference(firstDate, secondDate);

            Console.WriteLine(dateModifier.DaysDifference);
        }
    }
}