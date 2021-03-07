using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] newNums = new int[nums.Length - 1];

            while (nums.Length != 1)
            {
                int[] newNums = new int[nums.Length - 1];
                for (int i = 0; i < newNums.Length; i++)
                {
                    newNums[i] = nums[i] + nums[i + 1];
                }
                nums = newNums;               
            }
            Console.WriteLine(string.Join("", nums));
        }
    }
}
