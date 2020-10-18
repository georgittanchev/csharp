using System;
using System.Linq;
using System.Collections.Generic;

namespace _6.NewBombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombNumberAndPower[0];
            int bombPower = bombNumberAndPower[1];

            while (true)
            {
                int countOfNumbers = numbers.Count();
                int bombNumberIndex = numbers.IndexOf(bombNumber);
                if (bombNumberIndex == - 1)
                {
                    break;
                }
               
                if (bombNumberIndex + bombPower >= numbers.Count)
                {
                    int numbersCount = numbers.Count;
                    int difference = numbers.Count - bombNumberIndex;
                    numbers.RemoveRange(bombNumberIndex, difference);
                }
                // 0 1 2 3 4 5 6
                // 1 2 3 4 5 6 7
                else
                {
                    numbers.RemoveRange(bombNumberIndex, bombPower + 1);
                }

                int newRangeIndex = bombNumberIndex - bombPower;
                if (newRangeIndex >= 0)
                {
                    numbers.RemoveRange(newRangeIndex, bombPower);
                }
                else
                {
                    numbers.RemoveAt(0);
                }

                if (numbers.Contains(bombNumber))
                {
                    continue;
                }

                else
                {
                    Console.WriteLine(numbers.Sum());
                }
               
            }

        }
    }
}
