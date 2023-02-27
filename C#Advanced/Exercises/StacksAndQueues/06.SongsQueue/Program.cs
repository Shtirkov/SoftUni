namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");
            var songsQueue = new Queue<string>(songs);

            while (songsQueue.Count > 0)
            {
                var command = Console.ReadLine();

                if (command[0] == 'P')
                {
                    songsQueue.Dequeue();
                }
                else if (command[0] == 'A')
                {
                    var songToAdd = command.Substring(4, command.Length-4);

                    if (songsQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songToAdd);
                    }

                }
                else if (command[0] == 'S')
                {
                    Console.Write(String.Join(", ", songsQueue));
                    Console.WriteLine();
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}