using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> usefullMaterials = new Dictionary<string, int>();
            usefullMaterials.Add("shards", 0);
            usefullMaterials.Add("motes", 0);
            usefullMaterials.Add("fragments", 0);

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            int shards = 0;
            int fragments = 0;
            int motes = 0;

            while (true)
            {
                if (shards >= 250 || fragments >= 250 || motes >= 250)
                {
                    break;
                }

                string input = Console.ReadLine();
                input = input.ToLower();
                string[] splittedInput = input.Split();
                string material = "";
                int count = 0;

                for (int i = 0; i < splittedInput.Length; i++)
                {
                    if (shards >= 250 || fragments >= 250 || motes >= 250)
                    {
                        break;
                    }

                    if (i % 2 == 0)
                    {
                        count = int.Parse(splittedInput[i]);
                        material = splittedInput[i + 1];
                    }
                    i++;


                    if (material == "shards")
                    {
                        shards += count;

                        if (!usefullMaterials.ContainsKey(material))
                        {
                            usefullMaterials.Add(material, count);
                        }
                        else
                        {
                            usefullMaterials[material] += count;
                        }
                    }
                    else if (material == "motes")
                    {
                        motes += count;

                        if (!usefullMaterials.ContainsKey(material))
                        {
                            usefullMaterials.Add(material, count);
                        }
                        else
                        {
                            usefullMaterials[material] += count;
                        }
                    }
                    else if (material == "fragments")
                    {
                        fragments += count;

                        if (!usefullMaterials.ContainsKey(material))
                        {
                            usefullMaterials.Add(material, count);
                        }
                        else
                        {
                            usefullMaterials[material] += count;
                        }

                    }
                    if (!junk.ContainsKey(material))
                    {
                        if (material == "shards" || material == "motes" || material == "fragments")
                        {
                            continue;
                        }

                        junk.Add(material, count);
                    }
                    else
                    {
                        junk[material] += count;
                    }

                }
            }

            // usefullMaterials = usefullMaterials.OrderByDescending(item => item.Value).ToDictionary(x => x.Key, y => y.Value);



            foreach (var item in usefullMaterials)
            {
                if (item.Value >= 250)
                {

                    if (item.Key == "shards")
                    {
                        Console.WriteLine($"Shadowmourne obtained!");
                        shards -= 250;
                        usefullMaterials.Remove(item.Key);
                        usefullMaterials.Add(item.Key, shards);
                    }
                    else if (item.Key == "fragments")
                    {
                        Console.WriteLine("Valanyr obtained!");
                        fragments -= 250;
                        usefullMaterials.Remove(item.Key);
                        usefullMaterials.Add(item.Key, fragments);
                    }
                    else if (item.Key == "motes")
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        motes -= 250;
                        usefullMaterials.Remove(item.Key);
                        usefullMaterials.Add(item.Key, motes);
                    }
                    break;
                }
            }

            if (shards == motes || motes == fragments || shards == fragments)
            {
                usefullMaterials = usefullMaterials.OrderByDescending(item => item.Value).ThenBy(item => item.Key).ToDictionary(x => x.Key, y => y.Value);
            }
            else
            {
                usefullMaterials = usefullMaterials.OrderByDescending(item => item.Value).ToDictionary(x => x.Key, y => y.Value);
            }


            foreach (var item in usefullMaterials)
            {

                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
