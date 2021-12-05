using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<firstname>[A-Z][a-z]+) (?<lastname>[A-Z][a-z]+)";
            string text = Console.ReadLine();

            MatchCollection names = Regex.Matches(text, pattern);
            foreach (Match match in names)
            {
                Console.Write($"{match} ");
            }

       

        }
    }
}
