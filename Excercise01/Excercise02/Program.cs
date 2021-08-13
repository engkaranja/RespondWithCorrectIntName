using System;
using NumberExtension;

namespace Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            long number = Convert.ToInt64(input);
          string words = Excercise01.NumberToWords(number);

            Console.WriteLine(words);

        }
    }
}
