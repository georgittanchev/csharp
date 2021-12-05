using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<date>[\d]{2})(?<separator>[.\/-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[\d]{4})";
            string input = Console.ReadLine();
            MatchCollection myMatch = Regex.Matches(input, pattern);
            foreach (Match match in myMatch)
            {
                if (match.Success)
                {
                    string date = match.Groups["date"].Value;
                    string month = match.Groups["month"].Value;
                    string year = match.Groups["year"].Value;

                    Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
                }
            }
            

            
        }
    }
}
