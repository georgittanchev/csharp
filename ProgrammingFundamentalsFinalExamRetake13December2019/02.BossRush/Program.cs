using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string pattern = @"\|(?<name>[A-Z]{4,})\|:{1}#(?<title>[A-Za-z]+ [A-Za-z]+)#";
            for (int i = 0; i < numberOfInputs; i++)
            {
                string bossNameAndTitle = Console.ReadLine();
                Match isTheNameAndTitleValid = Regex.Match(bossNameAndTitle, pattern);
                if (isTheNameAndTitleValid.Success)
                {
                    int strenght = isTheNameAndTitleValid.Groups["name"].Value.Length;
                    int armour = isTheNameAndTitleValid.Groups["title"].Value.Length;
                    string name = isTheNameAndTitleValid.Groups["name"].Value;
                    string title = isTheNameAndTitleValid.Groups["title"].Value;

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {strenght}");
                    Console.WriteLine($">> Armour: {armour}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
