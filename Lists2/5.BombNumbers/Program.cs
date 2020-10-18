using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.BombNumbers
{

    class BombNumbers
    {

        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombNumberAndPower[0];
            int bombPower = bombNumberAndPower[1];

            while (true)
            {
                int numbersCount = numbers.Count;
                int indexOfTheBomb = numbers.IndexOf(bombNumber);

                if (indexOfTheBomb == -1)
                {
                    break;
                }

                int rightIndex = indexOfTheBomb + bombPower;

                for (int i = indexOfTheBomb; i <= rightIndex; i++)
                {
                    if (i < numbersCount)
                    {
                        numbers.RemoveAt(indexOfTheBomb);
                    }
                    else
                    {
                        break;
                    }
                }

                int leftIndex = indexOfTheBomb - bombPower;

                for (int i = indexOfTheBomb - 1; i >= leftIndex; i--)
                {
                    if (i >= 0)
                    {
                        numbers.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                }
            }


            Console.WriteLine(numbers.Sum());
        }


    }

}