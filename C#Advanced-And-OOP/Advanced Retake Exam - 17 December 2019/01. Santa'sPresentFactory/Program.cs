using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Santa_sPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMaterials = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var magicLevel = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<string, int> toys = new Dictionary<string, int>();
            int dolls = 0;
            int trains = 0;
            int bears = 0;
            int bikes = 0;

            //Doll - 150
            //Wooden Train - 250
            //Teddy Bear - 300
            //Bicycle - 400

            Stack<int> materials = new Stack<int>();
            Stack<int> magic = new Stack<int>();

            for (int i = 0; i < numberOfMaterials.Length; i++)
            {
                materials.Push(numberOfMaterials[i]);
            }

            for (int i = magicLevel.Length -1; i >= 0; i--)
            {
                magic.Push(magicLevel[i]);
            }

            while (materials.Count !=0 && magic.Count != 0)
            {
                int currentMaterial = materials.Peek();
                int currentMagic = magic.Peek();
                int total = currentMagic * currentMaterial;

                if (currentMagic == 0 || currentMaterial == 0 || (currentMagic == 0 && currentMaterial == 0))
                {
                    if (currentMagic == 0)
                    {
                        magic.Pop();
                    }

                    if (currentMaterial == 0)
                    {
                        materials.Pop();
                    }
                    continue;
                }

                if (total < 0)
                {
                    total = currentMaterial + currentMagic;
                    magic.Pop();
                    materials.Pop();
                    materials.Push(total);
                    continue;
                }

                if (total > 0 && total != 150 && total != 250 && total != 300 && total != 400)
                {
                    magic.Pop();
                    currentMaterial = materials.Pop() + 15;
                    materials.Push(currentMaterial);
                    continue;
                }

                if (total == 150 || total == 250 || total == 300 || total == 400)
                {
                    magic.Pop();
                    materials.Pop();

                    switch (total)
                    {
                        case 150:
                            if (!toys.ContainsKey("Doll"))
                            {
                                toys.Add("Doll", 0);
                            }
                            toys["Doll"]++;
                            dolls++;
                            break;
                        case 250:
                            if (!toys.ContainsKey("Wooden train"))
                            {
                                toys.Add("Wooden train", 0);
                            }
                            toys["Wooden train"]++;
                            trains++;
                            break;
                        case 300:
                            if (!toys.ContainsKey("Teddy bear"))
                            {
                                toys.Add("Teddy bear", 0);
                            }
                            toys["Teddy bear"]++;
                            bears++;
                            break;
                        case 400:
                            if (!toys.ContainsKey("Bicycle"))
                            {
                                toys.Add("Bicycle", 0);
                            }
                            toys["Bicycle"]++;
                            bikes++;
                            break;                            
                    }
                }
               
            }
            if ((dolls != 0 && trains !=0) || (bears != 0 && bikes !=0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ",materials)}");
            }

            if (magic.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magic)}");
            }

            toys = toys.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var toy in toys)
            {
                Console.WriteLine($"{toy.Key}: {toy.Value}");
            }
        }
    }
}
