﻿using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int whatWeWant = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
              for (int j = i+1; j < numbers.Length; j++)
                {

                    if (numbers[i] + numbers[j] == whatWeWant)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                        break;
                    }
                }
            }

           

            //Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.
        }
    }
}
