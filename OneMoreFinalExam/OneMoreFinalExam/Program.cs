using System;
using System.Linq;
using System.Text;

namespace OneMoreFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] instructions = command.Split(":|:");
                string theInstruction = instructions[0];
                if (theInstruction.Contains("InsertSpace"))
                {
                    int index = int.Parse(instructions[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }

                else if (theInstruction.Contains("Reverse"))
                {
                    string theSubString = instructions[1];
                    if (message.Contains(theSubString))
                    {
                        int index = message.IndexOf(theSubString);
                        int lenght = theSubString.Length;
                        message = message.Remove(index, lenght);
                        char[] reversedSubstring = theSubString.ToCharArray();
                        Array.Reverse(reversedSubstring);
                        string theReversed = new string(reversedSubstring);
                        message = message.Insert(message.Length, theReversed);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (theInstruction.Contains("ChangeAll"))
                {
                    string theSubString = instructions[1];
                    string replacement = instructions[2];
                    if (message.Contains(theSubString))
                    {
                        message = message.Replace(theSubString, replacement);
                        Console.WriteLine(message);
                    }
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
