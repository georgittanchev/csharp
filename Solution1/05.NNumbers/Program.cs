using System;

namespace _05.NNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbersCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MaxValue;
            int counter = 0;
            int number = 0;

            while (counter < numbersCount)
            {
                number = int.Parse(Console.ReadLine());
                counter++;
                if (number < maxNumber)
                {
                    maxNumber = number;
                    
                }

            }


            Console.WriteLine($"{maxNumber}");






        }
    }
}
