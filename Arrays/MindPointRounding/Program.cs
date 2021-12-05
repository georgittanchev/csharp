using System;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace AllInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                number = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {number}");
            }





            //Read an array of real numbers(space separated), round them in "away from 0" style and print the output as in the examples:
        }
    }
}
