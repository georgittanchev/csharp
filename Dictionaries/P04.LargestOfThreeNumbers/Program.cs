using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.LargestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] largestThree = numbers.OrderByDescending(n => n).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", largestThree));
            
        }
    }
}
