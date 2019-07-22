using System;


namespace _3_CapitalizeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an extension method that will capitalize a word.
            Console.WriteLine("Write a string.");
            string word = Console.ReadLine();
            Console.WriteLine(word.Capitalize());
        }
    }
}
