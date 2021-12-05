using System;

namespace _06.GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "int")
            {
                int firstOne = int.Parse(Console.ReadLine());
                int secondOne = int.Parse(Console.ReadLine());
                GetMax(firstOne, secondOne);
            }
            else if (command == "char")
            {
                char firstOne = char.Parse(Console.ReadLine());
                char secondOne = char.Parse(Console.ReadLine());
                GetMax(firstOne, secondOne);
            }
            else if (command == "string")
            {
                string firstOne = Console.ReadLine();
                string secondOne = Console.ReadLine();
                GetMax(firstOne, secondOne);
            }
        }

        static int GetMax(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
                return numberOne;
            }
            else
            {
                Console.WriteLine(numberTwo);
                return numberTwo;
            }
        }

        static char GetMax(char symbolOne, char symbolTwo)
        {
            if (symbolOne > symbolTwo)
            {
                Console.WriteLine(symbolOne);
                return symbolOne; 
            }
            else
            {
                Console.WriteLine(symbolTwo);
                return symbolTwo;
            }

          
        }

        static string GetMax(string messageOne, string messageTwo)
        {
            if (messageOne.Length > messageTwo.Length)
            {
                Console.WriteLine(messageOne);
                return messageOne;
            }
            else
            {
                Console.WriteLine(messageTwo);
                return messageTwo;
            }
        }
    }
}
