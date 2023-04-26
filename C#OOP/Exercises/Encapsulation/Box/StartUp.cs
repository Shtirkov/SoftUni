namespace Box
{
    public class StartUp
    {
        static void Main()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine()); 

            var box = new Box(length,width, height);
            Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
        }
    }
}