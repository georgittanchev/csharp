using System;
using System.Linq;
using System.Collections.Generic;


namespace P05.Words
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = Console.ReadLine().Split().ToArray();
            List<string> trueArray = array.Where(x => x.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join("\n", trueArray));

        }
    }
}
