﻿using System;

namespace _006.TriplesOfLatinLetter
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);

                for (int j = 0; j < n; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }






            //Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically:
        }
    }
}