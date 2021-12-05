using System;

namespace _14.OpeningBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberLines = int.Parse(Console.ReadLine());
            string something = string.Empty;
            int firstBracket = 0;
            int secondBracket = 0;

            for (int i = 0; i < numberLines; i++)
            {
                something = Console.ReadLine();

                if (something == "(")
                {
                    firstBracket++;
                }
                else if (something == ")")
                {
                    secondBracket++;
                    if (firstBracket < secondBracket)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

            }
            if (firstBracket == secondBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }


        }
    }
}
