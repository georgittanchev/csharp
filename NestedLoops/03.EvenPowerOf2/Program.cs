﻿using System;

namespace _03.EvenPowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(result);
                }

                result *= 2;
            }

       
        }
    }
}
