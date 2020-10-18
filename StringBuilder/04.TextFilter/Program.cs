using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            var bannedWords = Console.ReadLine().Split(", ").ToArray();
            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(text);
            
        }
    }
}
