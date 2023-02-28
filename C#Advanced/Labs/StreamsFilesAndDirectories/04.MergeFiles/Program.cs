namespace _04.MergeFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstFile = File.ReadAllLines("../../../FileOne.txt");
            var secondFile = File.ReadAllLines("../../../FileTwo.txt");
            var output = "../../../output.txt";
            using var writer = new StreamWriter(output);
            var firstFileIndex = 0;
            var secondFileIndex = 0;

            for (int i = 0; i < firstFile.Count() + secondFile.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    writer.WriteLine(firstFile[firstFileIndex]);
                    firstFileIndex++;
                }
                else
                {
                    writer.WriteLine(secondFile[secondFileIndex]);
                    secondFileIndex++;
                }                
            }
        }
    }
}