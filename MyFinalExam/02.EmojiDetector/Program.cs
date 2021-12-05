using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternText = @"(::|\*\*)(?<name>[A-Z][a-z]{2,})(\1)";
            string patternNumbers = @"\d";
            MatchCollection mathesText = Regex.Matches(input, patternText);
            MatchCollection matchesNumbers = Regex.Matches(input, patternNumbers);
            StringBuilder sb = new StringBuilder();
            int matchCounter = 0;
            long coolSum = 1;
            string result = string.Empty;
            int theNumber = 0;
            foreach (Match item in matchesNumbers)
            {
                theNumber = int.Parse(item.Value);
                coolSum *= theNumber;

            }



            foreach (Match item in mathesText)
            {
                matchCounter++;
                string name = item.Groups["name"].Value;
                double asciiSum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    char theChar = name[i];
                    int number = (int)theChar;
                    asciiSum += number;
                }
                if (asciiSum >= coolSum)
                {
                    sb.AppendLine(item.Groups[1].Value + item.Groups["name"].Value + item.Groups[2].Value);
                    result = sb.ToString();
                }
            }

            Console.WriteLine($"Cool threshold: {coolSum}");
            Console.WriteLine($"{matchCounter} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(" \n", result));
        }
    }
}
