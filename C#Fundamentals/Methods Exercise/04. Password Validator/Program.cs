using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }

        static void PasswordValidator(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                bool doesPassContainRestrictedSymbols = false;
                bool doesPasswordContainAtLeastTwoNumbers = false;
                int numbers = 0;

                foreach (var c in password)
                {
                    bool result = password.All(char.IsLetterOrDigit);
                    if (result == false)
                    {
                        doesPassContainRestrictedSymbols = true;
                        break;
                    }
                }

                foreach (var symbol in password)
                {
                    
                    if (char.IsDigit(symbol))
                    {
                        numbers++;
                    }

                    if (numbers >= 2)
                    {
                        doesPasswordContainAtLeastTwoNumbers = true;
                        break;
                    }                   
                }

                if (doesPassContainRestrictedSymbols == true)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (doesPasswordContainAtLeastTwoNumbers == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            else
            {
                bool doesPassContainRestrictedSymbols = false;
                bool doesPasswordContainAtLeastTwoNumbers = false;
                int numbers = 0;
                foreach (var c in password)
                {
                    bool result = password.All(char.IsLetterOrDigit);

                    if (result == false)
                    {
                        doesPassContainRestrictedSymbols = true;
                        break;
                    }
                }

                foreach (var symbol in password)
                {                   
                    if (char.IsDigit(symbol))
                    {
                        numbers++;
                    }
                   
                    if (numbers >= 2)
                    {
                        doesPasswordContainAtLeastTwoNumbers = true;
                        break;
                    }                  
                }

                if (doesPassContainRestrictedSymbols == true)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (doesPasswordContainAtLeastTwoNumbers == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

                if (doesPassContainRestrictedSymbols == false && doesPasswordContainAtLeastTwoNumbers == true)
                {
                    Console.WriteLine("Password is valid");
                }
            }
        }
    }
}

