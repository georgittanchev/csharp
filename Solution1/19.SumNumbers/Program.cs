using System;

namespace _19.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int numbers = 0;
            int sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                sum += numbers;

            }

            Console.WriteLine(sum);
        }
    }
}
