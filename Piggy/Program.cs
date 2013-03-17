using System;
using System.Text;

namespace Piggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piggy!\n\n(Ctrl+C to quit)\n");

            string input = string.Empty;

            while (true) {
                do {
                    Console.Write("Enter some text to convert to pig latin: ");
                    // Get the input and get rid of any excess whitespace.
                    input = Console.ReadLine().Trim();
                } while (string.IsNullOrWhiteSpace(input));

                Console.WriteLine(Piggy.Convert(input));
            }
        }
    }
}
