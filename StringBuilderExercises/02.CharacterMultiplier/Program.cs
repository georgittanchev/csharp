using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string bigger = string.Empty;
            string smaller = string.Empty;
            double result = 0;
            char lastChar = '*';
            if (input[0].Length > input[1].Length)
            {
                bigger = input[0];
                smaller = input[1];
            }
            else
            {
                bigger = input[1];
                smaller = input[0];
            }

            int difference = bigger.Length - smaller.Length;
            if (difference > 0)
            {
                for (int i = bigger.Length - 1; i > smaller.Length-1; i--)
                {
                   lastChar = bigger[i];
                    result += lastChar;
                }
            }
            for (int i = 0; i < bigger.Length - difference; i++)
            {
                char currentCharBigger = bigger[i];
                char currentCharSmaller = smaller[i];
               
                result += (currentCharBigger * currentCharSmaller);

            }
            Console.WriteLine(result);

            //Create a method that takes two strings as arguments and returns the sum of their character codes 
            //    multiplied(multiply str1[0] with str2[0] and add to the total sum).Then continue with the next
            //    two characters.If one of the strings is longer than the other, 
            //    add the remaining character codes to the total sum without multiplication.

        }
    }
}
