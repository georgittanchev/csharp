using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = Console.ReadLine()
                 .Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries)
                 .Reverse()
                 .ToList();
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}