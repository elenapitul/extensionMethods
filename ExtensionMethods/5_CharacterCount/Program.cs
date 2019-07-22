using System;

namespace _5_CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an extension method that will count the number of characters in a string.
            Console.WriteLine("Write a string.");
            string s = Console.ReadLine();
            Console.WriteLine(s.CharacterCount());
        }
    }
}
