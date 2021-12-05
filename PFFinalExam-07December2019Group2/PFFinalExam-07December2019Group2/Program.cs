using System;
using System.Linq;


namespace PFFinalExam_07December2019Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] splittedCommand = command.Split();
                string theCommand = splittedCommand[0];
                if (theCommand == "Replace")
                {
                    char currentChar = char.Parse(splittedCommand[1]);
                    char newChar = char.Parse(splittedCommand[2]);
                    message = message.Replace(currentChar, newChar);
                    Console.WriteLine(message);
                }
                else if (theCommand == "Cut")
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int endIndex = int.Parse(splittedCommand[2]);
                    int count = endIndex - startIndex;
                    if (startIndex < 0 || endIndex >= message.Length || startIndex >= message.Length || endIndex < 0 )
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        message = message.Remove(startIndex, count+1);
                        Console.WriteLine(message);
                    }
                }
                else if (theCommand == "Make")
                {
                    string subCommand = splittedCommand[1];
                    if (subCommand == "Lower")
                    {
                        message = message.ToLower();
                        
                    }
                    else if (subCommand == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    Console.WriteLine(message);
                }
                else if (theCommand == "Check")
                {
                    string doesItContainIt = splittedCommand[1];
                    if (message.Contains(doesItContainIt))
                    {
                        Console.WriteLine($"Message contains {doesItContainIt}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {doesItContainIt}");
                    }
                }
                else if (theCommand == "Sum")
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int endIndex = int.Parse(splittedCommand[2]);
                    if (startIndex < 0 || endIndex >= message.Length || startIndex >= message.Length || endIndex < 0)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        double number = 0;
                        string substring = message.Substring(startIndex, endIndex);
                        for (int i = 0; i < substring.Length; i++)
                        {
                            number += substring[i];
                        }
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
