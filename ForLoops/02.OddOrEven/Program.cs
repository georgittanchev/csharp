using System;

namespace _02.OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа, подадени от потребителя, и проверява дали сумата от 
            //    числата на четни позиции е равна на сумата на числата на нечетни позиции. При равенство да се отпечатат два реда:
            //"Yes" и на нов ред "Sum = " + сумата; иначе да се отпечата "No" и на нов ред "Diff = " + разликата.Разликата се изчислява
            //    по абсолютна стойност.


            int numbersCounter = 0;
            int numbersCount = int.Parse(Console.ReadLine());
            int numbers = 0;
            int even = 0;
            int odd = 0;
            int Sum = 0;
            int diffenrece = 0;


            for (numbersCounter = 0; numbersCounter < numbersCount; numbersCounter++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (numbersCounter % 2 == 0)
                {
                    even += numbers;
                }
                else
                {
                    odd += numbers;
                }
             
            }
            if (even == odd)
            {
                Sum = even;
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {Sum} ");
            }
            else
            {
                diffenrece = Math.Abs(even - odd);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diffenrece} ");
            }

        }
    }
}
