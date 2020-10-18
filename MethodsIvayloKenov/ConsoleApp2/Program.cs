using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSumOfEvenAndOddDigitsAndMultiplyThem(theNumber) ); 
            
        }

        static int GetSumOfEvenAndOddDigitsAndMultiplyThem(int number)
        {
            int nextNumber = 0;
            int sumEven = 0;
            int sumOdd = 0;
            int allSum = 0;
            while (number != 0)
            {
                nextNumber = Math.Abs(number % 10);
                if (nextNumber % 2 == 0)
                {
                    sumEven += nextNumber;
                }
                else
                {
                    sumOdd += nextNumber;
                }

                number /= 10;
            }

            allSum = Math.Abs(sumOdd * sumEven);
            return allSum;

        }

    }

}