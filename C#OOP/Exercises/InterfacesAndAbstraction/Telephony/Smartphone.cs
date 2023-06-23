using System;
using Telephony.Interfaces;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public void Browse(string url)
        {
            if (!url.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine($"Browsing: {url}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }

        public void Call(string number)
        {

            if (number.All(c => char.IsDigit(c)))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
