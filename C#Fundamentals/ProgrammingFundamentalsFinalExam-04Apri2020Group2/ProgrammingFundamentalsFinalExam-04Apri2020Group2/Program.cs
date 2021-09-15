using System;

namespace ProgrammingFundamentalsFinalExam_04Apri2020Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Done")
                {
                    break;
                }

                string command = input.Split()[0];

                switch (command)
                {
                    case "TakeOdd":
                        string newPassword = "";

                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 == 1 && i != 0)
                            {
                                newPassword += string.Concat(password[i]);
                            }
                        }
                        password = newPassword;
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(input.Split()[1]);
                        int length = int.Parse(input.Split()[2]);

                        //string substring = password.Substring(index, length);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string stringToReplace = input.Split()[1];
                        string substitute = input.Split()[2];

                        if (password.Contains(stringToReplace))
                        {
                            password = password.Replace(stringToReplace, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;                   
                }

            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
