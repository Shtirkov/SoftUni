using CollectionHierarchy.Models;
using System.Text;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var output = new StringBuilder();

            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            var countOfRemoveOperations = int.Parse(Console.ReadLine());

            input.ForEach(x => output.Append($"{addCollection.Add(x)} "));
            output.AppendLine();

            input.ForEach(x => output.Append($"{addRemoveCollection.Add(x)} "));
            output.AppendLine();

            input.ForEach(x => output.Append($"{myList.Add(x)} "));
            output.AppendLine();

            for (int i = 0; i < countOfRemoveOperations; i++)
            {
                output.Append($"{addRemoveCollection.Remove()} ");
            }

            output.AppendLine();

            for (int i = 0; i < countOfRemoveOperations; i++)
            {
                output.Append($"{myList.Remove()} ");
            }

            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}