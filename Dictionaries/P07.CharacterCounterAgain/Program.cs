using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.CharacterCounterAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            Dictionary<char, int> library = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];

                if (character != ' ' )
                {
                  
                        if (!library.ContainsKey(character))
                        {
                            library[character] = 0;
                        }

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
