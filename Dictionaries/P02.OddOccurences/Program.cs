using System;
using System.Linq;
using System.Collections.Generic;

namespace P02.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Write a program that extracts all elements from a given sequence of words that are present in it an odd 
            //                number of times(case-insensitive).
            //⦁	Words are given on a single line, space separated.
            //⦁	Print the result elements in lowercase, in their order of appearance.

            string[] words = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> library = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!library.ContainsKey(word))
                {
                    library[word] = 0;
                }

                library[word] += 1;
            
            }

            foreach (var item in library)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }


        }
    }
}
