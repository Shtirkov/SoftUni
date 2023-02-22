using System.Text;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputLinesCount = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string,int>>();

            for (int i = 0; i < inputLinesCount; i++)
            {
                var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();
                var color = input[0];
                var clothes = input[1].Split(',').ToList();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int k = 0; k < clothes.Count; k++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[k]))
                    {
                        wardrobe[color].Add(clothes[k], 0);
                    }

                    wardrobe[color][clothes[k]]++;
                }
            }

            var desiredClothInformationAsArray = Console.ReadLine().Split();
            var desiredClothColor = desiredClothInformationAsArray[0];
            var desiredClothType = desiredClothInformationAsArray[1];

            foreach (var row in wardrobe)
            {
                var output = new StringBuilder();
                output.AppendLine($"{row.Key} clothes:");

                foreach (var cloth in row.Value)
                {
                    if (desiredClothColor == row.Key && desiredClothType == cloth.Key)
                    {
                        output.AppendLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        output.AppendLine($"* {cloth.Key} - {cloth.Value}");

                    }
                }
                Console.Write(output.ToString());
            }
        }
    }
}