using System;
using System.Text.RegularExpressions;

namespace _02.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string pattern = @"U\$(?<name>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}[A-Za-z0-9]*[0-9]+)P@\$";
            string input = string.Empty;
            int registrationCounter = 0;
            for (int i = 0; i < numberOfInputs; i++)
            {
                input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                   
                    Console.WriteLine("Registration was successful");
                    registrationCounter++;
                    Console.WriteLine($"Username: {match.Groups["name"]}, Password: {match.Groups["password"]}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {registrationCounter}");
        }
    }
}
