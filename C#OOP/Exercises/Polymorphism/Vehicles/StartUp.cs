using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           var engine = new Engine();
            engine.Start();
        }
    }
}