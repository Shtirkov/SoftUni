using System;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
               // string trimmedUsername = username.Trim();
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;

                    foreach (var symbol in username)
                    {
                        if (!char.IsDigit(symbol) && !char.IsLetter(symbol) && symbol != '-' && symbol != '_')
                        {
                            isValid = false;                            
                        }
                    }
                    if (isValid == true)
                    {
                        Console.WriteLine(username);
                    }
                   
                }
            }
        }
    }
}
