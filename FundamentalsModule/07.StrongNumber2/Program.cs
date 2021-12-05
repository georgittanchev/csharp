using System;

namespace _07.StrongNumber2
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int digitSaver = number;

            double totalSum = 0;


            while (digitSaver > 0)
            {

                int lastDigit = digitSaver % 10;
                digitSaver /= 10;

                double sum = 1;

                for (int i = lastDigit; i > 0; i--)
                {

                    sum *= i;

                }

                totalSum += sum;

            }

            if (totalSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
