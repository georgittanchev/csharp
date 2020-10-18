using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string rawKey = Console.ReadLine();
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] splittedInput = input.Split(">>>");
                string command = splittedInput[0];
                if (command == "Contains")
                {
                    string substring = splittedInput[1];
                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string subCommand = splittedInput[1];
                    int startIndex = int.Parse(splittedInput[2]);
                    int endIndex = int.Parse(splittedInput[3]);
                    if (subCommand == "Upper")
                    {
                        int count = endIndex - startIndex;
                        string subString = rawKey.Substring(startIndex, count).ToUpper();
                        rawKey = rawKey.Remove(startIndex, count);
                        rawKey = rawKey.Insert(startIndex, subString);
                        Console.WriteLine(rawKey);

                    }
                    else if (subCommand == "Lower")
                    {
                        int count = endIndex - startIndex;
                        string subString = rawKey.Substring(startIndex, count).ToLower();
                        rawKey = rawKey.Remove(startIndex, count);
                        rawKey = rawKey.Insert(startIndex, subString);
                        Console.WriteLine(rawKey);
                    }
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(splittedInput[1]);
                    int endIndex = int.Parse(splittedInput[2]);
                    int lenght = endIndex - startIndex;
                    rawKey = rawKey.Remove(startIndex, lenght);
                    Console.WriteLine(rawKey);

                }
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
