using System;

namespace _01.NumbersInRange2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (!(number >= 1 && number <= 100))
            {
                Console.WriteLine("Invalid number!");
                 number = double.Parse(Console.ReadLine());

            }
            Console.WriteLine($"The number is: {number}");


        }
    }
}
