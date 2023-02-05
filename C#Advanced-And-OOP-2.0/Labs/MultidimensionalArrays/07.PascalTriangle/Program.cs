namespace _07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangleSize = int.Parse(Console.ReadLine());
            var triangle = new long[triangleSize][];

            for (int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;

                if (row > 1)
                {
                    for (int col = 1; col < triangle[row].Length - 1; col++)
                    {
                        triangle[row][col] = triangle[row - 1][col] + triangle[row - 1][col - 1];
                    }
                }               
            }

            foreach (var nestedArray in triangle)
            {
                Console.WriteLine(string.Join(' ',nestedArray));
            }
        }
    }
}