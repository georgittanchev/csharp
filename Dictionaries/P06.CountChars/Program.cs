using System;
using System.Linq;
using System.Collections.Generic;

namespace P06.CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            Dictionary<char, int> library = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
         
                char character = words[i];

                if (character != ' ')
                {

                    if (!library.ContainsKey(character))
                    {
                        library[character] = 0;
                    } // На този речник, този Key, Value-то му е 0;
                    library[character] += 1;
               
                }
            }
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


           
        }
    }
}
