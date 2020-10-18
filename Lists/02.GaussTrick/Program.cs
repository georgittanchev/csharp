using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> array = Console.ReadLine().Split().Select(double.Parse).ToList();

            SumTheFirstAndLastSum(array);
        
        }

        static void SumTheFirstAndLastSum(List<double> numbers)
        {
            List<double> newArray = new List<double>(numbers);

            for (int i = 0; i < newArray.Count / 2; i++)
            {

                numbers[i] += numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);
            }

            Console.Write(string.Join(" ", numbers));


        }
    }
}