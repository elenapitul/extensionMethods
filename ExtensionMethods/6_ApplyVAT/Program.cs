using System;

namespace _6_ApplyVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an extension method that will apply a VAT of 24% on an input.
            //This input can be a decimal value, or an integer.
            Console.WriteLine("Write a number");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(number.ApplyVAT());
        }
    }
}
