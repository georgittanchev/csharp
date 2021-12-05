using System;
using System.Linq;
using System.Text;

namespace PFFinalExam_03August2019Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] splittedInput = input.Split();
                string command = splittedInput[0];
                if (command == "Change")
                {
                    char oldChar = char.Parse(splittedInput[1]);
                    char newChar = char.Parse(splittedInput[2]);
                    message = message.Replace(oldChar, newChar);
                    Console.WriteLine(message);
                }
                else if (command == "Includes")
                {
                    string doesItIncludeIt = splittedInput[1];
                    if (message.Contains(doesItIncludeIt))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "End")
                {
                    string toEndWith = splittedInput[1];

                    if (message.EndsWith(toEndWith))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }
                else if (command == "FindIndex")
                {
                    char charToFindIndex = char.Parse(splittedInput[1]);
                    int index = message.IndexOf(charToFindIndex);
                    Console.WriteLine(index);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(splittedInput[1]);
                    int lenght = int.Parse(splittedInput[2]);
                    message = message.Substring(startIndex, lenght);
                    Console.WriteLine(message);
                }
            }
        }
    }
}
