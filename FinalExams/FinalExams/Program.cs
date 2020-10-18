using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinalExams
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] splitedInput = input.Split();
                if (splitedInput.Contains("Make"))
                {
                    string command = splitedInput[0];
                    string commandDefinition = splitedInput[1];
                    if (commandDefinition == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine($"{email}");
                    }
                    else if (commandDefinition == "Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine($"{email}");
                    }
                }
                else if (splitedInput.Contains("GetDomain"))
                {
                    int commandCount = int.Parse(splitedInput[1]);
                    string domain = email.Substring(email.Length - commandCount, commandCount);
                    Console.WriteLine($"{domain}");
                }
                else if (splitedInput.Contains("GetUsername"))
                {
                    if (!email.Contains("@"))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        int indexOfAt = email.IndexOf("@");
                        string startOfTheEmail = email.Substring(0, indexOfAt);
                        Console.WriteLine(startOfTheEmail);
                    }
                }
                else if (splitedInput.Contains("Replace"))
                {
                    char charToReplace = char.Parse(splitedInput[1]);
                    email = email.Replace(charToReplace, '-');
                    Console.WriteLine(email);
                }
                else if (splitedInput.Contains("Encrypt"))
                {
                    foreach (var c in email)
                    {
                        Console.Write((int)c + " ");
                    }
                }
            }
        }
    }
}
