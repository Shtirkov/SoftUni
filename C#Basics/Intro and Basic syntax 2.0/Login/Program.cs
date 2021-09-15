using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            char[] cArray = userName.ToCharArray();
            string correctPassWord = "";
            for (int i = cArray.Length - 1; i >= 0; i--)
            {
                correctPassWord += cArray[i];
            }

            string passWord = Console.ReadLine();
            int wrongAttempts = 0;           

            while (passWord != correctPassWord && wrongAttempts < 3)
            {
                wrongAttempts++;
                Console.WriteLine($"Incorrect password. Try again.");               
                passWord = Console.ReadLine();
            }

            if (passWord == correctPassWord)
            {
                Console.WriteLine($"User {userName} logged in.");
            }

            if (wrongAttempts >= 3)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}
