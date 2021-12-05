using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _02.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfMessage = int.Parse(Console.ReadLine());
            string message = string.Empty;
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < counterOfMessage; i++)
            {
                message = Console.ReadLine();
                Match messages = Regex.Match(message, pattern);
                int number = 0;
                if (messages.Success)
                {
                    string command = messages.Groups["command"].Value;
                    string theMessages = messages.Groups["message"].Value;
                    for (int d = 0; d < theMessages.Length; d++)
                    {
                        number = theMessages[d];
                        sb.Append(number + " ");
                    }
                    Console.WriteLine($"{command}: {sb}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
        }
    }
}
