using System;
using System.Linq;
using System.Collections.Generic;

namespace _P03.WordSynonyms
{
    class WordSynonyms
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            Dictionary <string, List<string>> synonymLibrary  = new Dictionary<string, List<string>>();
            for (int i = 0; i < numbers; i++)
            {
                string word = Console.ReadLine();
                if (!synonymLibrary.ContainsKey(word))
                {
                    synonymLibrary.Add(word, new List<string>());
                }
                string synonym = Console.ReadLine();
                if (!synonymLibrary[word].Contains(synonym))
                {
                    synonymLibrary[word].Add(synonym);
                }
            }
            foreach (var item in synonymLibrary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
             
        }

    }
}