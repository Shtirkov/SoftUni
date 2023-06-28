using CollectionHierarchy.Models;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var test = new AddCollection();
            test.Add("d");
            test.Add("c");
            test.Add("b");
            test.Add("a");

            for (int i = 0; i < test.Length; i++)
            {
                //Console.WriteLine(test[i]);
            }


        }
    }
}