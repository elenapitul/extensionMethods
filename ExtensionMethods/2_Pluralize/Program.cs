using System;
using System.Linq;
using System.Text;

namespace _2_Pluralize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an extension method that appends an 's' to a string
            

            Console.WriteLine("Write a word.");
            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(word);

            Console.WriteLine("The plural of " + word + " is " + sb.Pluralize());
        }
    }
}
