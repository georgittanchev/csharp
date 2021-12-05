using System;
using System.Linq;

namespace PFFinalExamRetake_9August2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string input = string.Empty;
            string reversed = string.Empty;
            while ((input = Console.ReadLine()) != "Sign up")
            {
                string[] splittedInput = input.Split();
                string command = splittedInput[0];
                if (command == "Case")
                {
                    string subCommand = splittedInput[1];
                    if (subCommand == "upper")
                    {
                        userName = userName.ToUpper();
                        Console.WriteLine(userName);
                    }
                    else if (subCommand == "lower")
                    {
                        userName = userName.ToLower();
                        Console.WriteLine(userName);
                    }
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(splittedInput[1]);
                    int endIndex = int.Parse(splittedInput[2]);
                    int count = endIndex - startIndex;
                    if (startIndex >= 0 && endIndex < userName.Length)
                    {
                        reversed = userName.Substring(startIndex, count + 1);
                        char[] reversedCharArray = reversed.ToCharArray();
                        Array.Reverse(reversedCharArray);
                        reversed = new string(reversedCharArray);
                        Console.WriteLine(reversed);

                    }  
                }
                else if (command == "Cut")
                {
                    string subStringToRemove = splittedInput[1];
                    if (userName.Contains(subStringToRemove))
                    {
                       int indexOf = userName.IndexOf(subStringToRemove);
                       userName = userName.Remove(indexOf, subStringToRemove.Length); // Moje da grumne ako ne nameri indexap praiwlno**
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {subStringToRemove}.");
                    }
                }
                else if (command == "Replace")
                {
                    char charToRemove = char.Parse(splittedInput[1]);
                    userName = userName.Replace(charToRemove, '*');
                    Console.WriteLine(userName);
                }
                else if (command == "Check")
                {
                    char character = char.Parse(splittedInput[1]);
                    if (!userName.Contains(character))
                    {
                        Console.WriteLine($"Your username must contain {character}.");
                    }
                    else
                    {
                        Console.WriteLine("Valid");
                    }

                }
            }
        }
    }
}
