using System;
using System.Diagnostics.Tracing;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string singleString = Console.ReadLine();
            PrintTheMiddleCharacter(singleString);

        }

       static void PrintTheMiddleCharacter (string singleString)
        {
            if (singleString.Length % 2 == 0)
            {
                int index = singleString.Length / 2;
                string newString = singleString.Substring(index-1, 2);
                Console.WriteLine(newString);
            }

            else
            {
                int index = singleString.Length / 2;
                string newString = singleString.Substring(index, 1);
                Console.WriteLine(newString);
            }
        }


    }

}