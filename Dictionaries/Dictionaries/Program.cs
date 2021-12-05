using System;
using System.Linq;
using System.Collections.Generic;

namespace _P01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();
            foreach (var item in numbers)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary[item] = 0;
                }

                dictionary[item] += 1;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }




        }
    }
}