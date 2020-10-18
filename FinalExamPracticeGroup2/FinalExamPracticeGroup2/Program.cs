using System;

namespace FinalExamPracticeGroup2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Done")
            {
                string[] input = commands.Split();
                string command = input[0];
                if (command == "TakeOdd")
                {
                    string newPassword = string.Empty;
                    for (int i = 0; i < message.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPassword += message[i];
                        }
                    }

                    message = newPassword;

                    Console.WriteLine(message);
                }

                else if (command == "Cut")
                {
                    int index = int.Parse(input[1]);
                    int lenght = int.Parse(input[2]);
                    string newSubstring = message.Substring(index, lenght);
                    int indexInTheMessage = message.IndexOf(newSubstring);
                    message = message.Remove(indexInTheMessage, lenght);
                    Console.WriteLine(message);
                }

                else if (command == "Substitute")
                {
                    string substring = input[1];
                    string substitute = input[2];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, substitute);
                        Console.WriteLine(message);
                    }

                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {message}");
        }
    }
}
