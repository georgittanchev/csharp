using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _05.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            StringBuilder realNames = new StringBuilder();
            Dictionary<string, double> nameDictionary = new Dictionary<string, double>();
            string input;
            string namePattern = @"(?<namepattern>[^\d%@!_\-=+#$^&*()|?\/\\])";
            string digitPattern = @"[\d]";
            double nameSum = 0;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection match = Regex.Matches(input, namePattern);
                foreach (Match match1 in match)
                {
                    if (match1.Success)
                    {
                        realNames.Append(match1);
                    }
                }
                string name = realNames.ToString();
                if (participants.Contains(name))
                {
                    if (!nameDictionary.ContainsKey(name))
                    {
                        nameDictionary.Add(name, 0);
                    }
                  
                    MatchCollection digitMatch = Regex.Matches(input, digitPattern);
                    foreach (Match item in digitMatch)
                    {
                        if (item.Success)
                        {
                            nameSum += double.Parse(item.Value);
                        }
                    }
                    nameDictionary[name] += nameSum;
                    realNames.Clear();
                    nameSum = 0;
                }
                else
                {
                    realNames.Clear();
                }
            }

            nameDictionary = nameDictionary.OrderByDescending(x => x.Value).Take(3).ToDictionary(a => a.Key, b => b.Value);
            int counter = 1;
            string place = "st place:";
            foreach (var item in nameDictionary)
            {
               
                if (counter == 2)
                {
                    place = "nd place:";
                }
                else if (counter == 3)
                {
                    place = "rd place:";
                }
          
                Console.WriteLine($"{counter}{place} {item.Key}");
                counter++;
            }

        }
    }
}
