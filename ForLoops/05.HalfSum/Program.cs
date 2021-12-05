using System;

namespace _05.HalfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа, въведени от потребителя, и проверява дали сред тях съществува число, 
            //което е равно на сумата на всички останали. Ако има такъв елемент, печата "Yes", "Sum = " + неговата стойност; иначе 
            //печата "No", "Diff = " 
            //    + разликата между най-големия елемент и сумата на останалите(по абсолютна стойност).

            int numbersCount = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int sum = 0;
            int diff = 0;

            for (int counter = 0; counter < numbersCount; counter++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > max)
                {
                    max = numbers;
                    
                }
                
                sum += numbers;
                

            }
            sum -= max;
            if (max == sum)

            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                diff = Math.Abs(sum - max);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
