using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstNumber = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> secondNUmber = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();

            int bigger = 0;

            if (firstNumber.Count > secondNUmber.Count)
            {
                bigger = firstNumber.Count;
            }
            else
            {
                bigger = secondNUmber.Count;
            }

            for (int i = 0; i < bigger; i++)
            {
                if (i < firstNumber.Count)
                {
                    result.Add(firstNumber[i]);
                }
                if (i < secondNUmber.Count)
                {
                    result.Add(secondNUmber[i]);
                }
            }
            Console.Write(string.Join(" ", result));
        }

      
    }
}
