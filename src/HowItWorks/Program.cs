using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HowItWorks
{
    internal class Program
    {
        private static void Main()
        {
            const string text = "Hello world";

            var bytes = Encoding.UTF8.GetBytes(text);
            var hashstring = new SHA256Managed();
            var hash = hashstring.ComputeHash(bytes);
            var sha256 = hash.Aggregate(string.Empty, (current, x) => current + $"{x:x2}");

            Console.WriteLine(sha256);
        }
    }
}
