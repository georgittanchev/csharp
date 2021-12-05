using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string pattern = @"(.+)>(?<One>\d{3})\|(?<Two>[a-z]{3})\|(?<Three>[A-Z]{3})\|(?<Four>[^<>]{3})<\1";
            StringBuilder encryptedPassword = new StringBuilder();
            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                Match passwords = Regex.Match(input, pattern);
                if (passwords.Success)
                {

                    string groupOne = passwords.Groups["One"].Value;
                    string groupTwo = passwords.Groups["Two"].Value;
                    string groupThree = passwords.Groups["Three"].Value;
                    string groupFour = passwords.Groups["Four"].Value;
                    encryptedPassword.Append(groupOne);
                    encryptedPassword.Append(groupTwo);
                    encryptedPassword.Append(groupThree);
                    encryptedPassword.Append(groupFour);
                    string result = encryptedPassword.ToString();
                    Console.WriteLine($"Password: {result}");
                    encryptedPassword = new StringBuilder();
                }
                else
                {
                    Console.WriteLine("Try another password!");

                }
            }
        }
    }
}
