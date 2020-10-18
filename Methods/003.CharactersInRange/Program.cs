using System;

namespace _003.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {

            char text = ' ';

            CharactersInRange(text);





            //Write a method that receives two characters and prints on a single line all the characters in between them according to ASCII.
        }

        static char CharactersInRange(char range)
        {

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char symbol = ' ';

            int maxSymbol = Math.Max(firstChar, secondChar);
            int minSymbol = Math.Min(firstChar, secondChar);

            for (int i = minSymbol + 1; i < maxSymbol; i++)
            {
                symbol = (char)i;
                Console.Write(symbol + " ");
            }

            return range;
        }
    }
}
