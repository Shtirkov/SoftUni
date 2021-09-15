using System;
using System.Linq;

namespace _04._Array_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = new int[arr.Length];
            int length = arr.Length;
            int numberOfRotations = int.Parse(Console.ReadLine());
            arr2 = arr;

            for (int i = 0; i < numberOfRotations; i++)
            {
                var head = arr[0];
                Array.Copy(arr, 1, arr, 0, arr.Length - 1);
                arr[arr.Length - 1] = head;                
            }
            Console.Write(string.Join(" ", arr));
        }
    }
}
