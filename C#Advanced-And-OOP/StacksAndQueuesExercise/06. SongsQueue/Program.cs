using System;
using System.Collections.Generic;

namespace _06._SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string input = Console.ReadLine();
                string command = input.Split()[0];

                switch (command)
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string song = input.Remove(0, 4);
                        song = song.Trim();
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(song);
                        }
                        break;
                    case "Show":
                        int counter = queue.Count;

                        for (int i = 0; i < counter; i++)
                        {
                            if (i+1 == queue.Count)
                            {
                                Console.Write($"{queue.Peek()}\n");
                                string currentSong = queue.Dequeue();
                                queue.Enqueue(currentSong);
                            }
                            else
                            {
                                Console.Write($"{queue.Peek()}, ");
                                string currentSong = queue.Dequeue();
                                queue.Enqueue(currentSong);
                            }                            
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
