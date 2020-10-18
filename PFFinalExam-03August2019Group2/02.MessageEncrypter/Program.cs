using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _02.MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<closingtag>\*|@)(?<tag>[A-Z]{1}[a-z]{2,})\k<closingtag>: \[(?<ecnryptingNumber>[a-zA-Z])\]\|\[(?<ecnryptingNumber2>[a-zA-Z])\]\|\[(?<ecnryptingNumber3>[a-zA-Z])\]\|$";
            int numberOfLines = int.Parse(Console.ReadLine());
            string input = string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numberOfLines; i++)
            {
                input = Console.ReadLine();
                Match encryption = Regex.Match(input, pattern);
                if (encryption.Success)
                {

                    string whatToEncrypt = string.Empty;
                    whatToEncrypt += encryption.Groups["ecnryptingNumber"].Value + encryption.Groups["ecnryptingNumber2"].Value + encryption.Groups["ecnryptingNumber3"].Value;
                    for (int a = 0; a < whatToEncrypt.Length; a++)
                    {
                        int number = whatToEncrypt[a];
                        sb.Append(number + " ");
                    }
              
                    string command = encryption.Groups["tag"].Value;
                    Console.WriteLine($"{command}: {sb}");
                    sb = new StringBuilder();
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
