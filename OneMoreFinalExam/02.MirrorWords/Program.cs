using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textPattern = @"(?<deviders>[#\|@])(?<words>[A-Za-z]{3,})\k<deviders>{2}(?<words2>[A-Za-z]{3,})\k<deviders>";
            MatchCollection mirrorWords = Regex.Matches(text, textPattern);
            List<string> wordsThatMatch = new List<string>();
            int mirrorCounter = 0;
            foreach (Match match in mirrorWords)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["words"].Value;
                    string secondWord = match.Groups["words2"].Value;
                    char[] myArr = secondWord.ToCharArray();
                    Array.Reverse(myArr);
                    string myReversedWord = new string(myArr);
                    if (firstWord == myReversedWord)
                    {
                        string mirror = firstWord + " <=> " + secondWord;
                        wordsThatMatch.Add(mirror);
                        mirrorCounter++;
                    }
                }
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }

            else
            {
                Console.WriteLine($"{mirrorWords.Count} word pairs found!");
            }

            if (mirrorCounter == 0)
            {
                Console.WriteLine("No mirror words!");
            }

            else
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", wordsThatMatch));
            }
        }
    }
}
