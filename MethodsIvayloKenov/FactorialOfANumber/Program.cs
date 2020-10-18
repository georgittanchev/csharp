using System;

namespace FactorialOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());
            Factorials(firstNumber, secondNumber);
        }

        static void Factorials(double first, double second)
        {
            double factorialFirst = first;
            double factorialSecond = second;

            for (double i = first; i >= 2; i--)
            {
                factorialFirst = factorialFirst * (i - 1);
            }

            for (double i = second; i >= 2; i--)
            {
                factorialSecond = factorialSecond * (i - 1);
            }

            double sum = factorialFirst / factorialSecond;
            Console.WriteLine($"{sum:F2}");

        }
    }
}
