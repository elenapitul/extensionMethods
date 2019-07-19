using _3_CapitalizeWord;
using _2_Pluralize;
using System;
using System.Text;

namespace _4_CapitalizeAndPluralize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will capitalize a string and pluralize the same string.
            Console.WriteLine("Write a string.");
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(word);           

            Console.WriteLine(sb.Pluralize().ToString().Capitalize());
          
        }
    }
}
