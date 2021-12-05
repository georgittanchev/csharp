using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            var word = Console.ReadLine().ToLower();
            var line = Console.ReadLine().ToLower();

            for (int i = 0; i < line.Length; i++)
            {
                line = line.Replace(word, string.Empty);
            }

            Console.WriteLine(line);
        }
    }
}

