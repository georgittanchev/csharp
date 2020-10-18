using System;

namespace _20.NewForLoopSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int numbers = 0;
            int sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (numbers > max)
                {
                    max = numbers;
                }
                if ( numbers < min)
                {
                    min = numbers;
                }
            }

            

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
