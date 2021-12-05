using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    
                    sumEven += numbers[i];
                }
                else
                {
                    
                    sumOdd += numbers[i];
                }
            }

            int difference = sumEven - sumOdd;

            Console.WriteLine(difference);


            //Write a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.

        }
    }
}
