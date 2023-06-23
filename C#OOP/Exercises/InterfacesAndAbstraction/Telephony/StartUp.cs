namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToList();
            var urls = Console.ReadLine().Split().ToList();
            var smartPhone = new Smartphone();
            var stationaryPhone = new StationaryPhone();

            numbers.ForEach(number =>
            {
                if (number.Length == 10)
                {
                    smartPhone.Call(number);
                }
                else if (number.Length == 7)
                {
                    stationaryPhone.Call(number);
                }
            });

            urls.ForEach(url => smartPhone.Browse(url));
        }
    }
}