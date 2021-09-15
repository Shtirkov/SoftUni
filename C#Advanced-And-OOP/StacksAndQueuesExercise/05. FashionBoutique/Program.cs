using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int rackCounter = 0;
            int clothesSum = 0;

            while (stack.Count != 0)
            {
                int currentCloth = stack.Peek();
                clothesSum += currentCloth;

                if (clothesSum  == rackCapacity)
                {
                    stack.Pop();
                    rackCounter++;
                    clothesSum = 0;
                }
                else if (clothesSum < rackCapacity)
                {
                    stack.Pop();

                    if (stack.Count == 0)
                    {
                        rackCounter++;
                    }
                }
                else if (clothesSum > rackCapacity)
                {
                    rackCounter++;
                    clothesSum = 0;
                }


                //if (clothesSum == rackCapacity)
                //{
                //    rackCounter++;
                //    clothesSum = 0;
                //}
                //else if (clothesSum < rackCapacity)
                //{
                //    int currentCloth = stack.Peek();
                //    clothesSum += currentCloth;

                //    if (clothesSum > rackCapacity)
                //    {
                //        stack.Push(currentCloth);
                //        rackCounter++;
                //        clothesSum = 0;
                //    }
                //    else
                //    {
                //        stack.Pop();
                //    }
            }
            Console.WriteLine(rackCounter);
        }
    }
}

