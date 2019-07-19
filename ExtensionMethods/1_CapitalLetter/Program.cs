using System;
using System.Linq;

namespace _1_CapitalLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an extension method to check if a string starts with a capital letter or not.
            string a = "abcde";
            string b = "Abcde";

            Console.WriteLine(a.CapitalLetter());
            Console.WriteLine(b.CapitalLetter());
        }       
        
    }
}
