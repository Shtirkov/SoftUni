using Raiding.Core;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Factory pattern for creating heroes to be implemented

            var engine = new Engine();

            try
            {
                engine.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}