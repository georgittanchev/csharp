using System;

namespace _01.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
       {
            //Да се напише програма, която чете 2 * n - на брой цели числа, подадени от потребителя, и проверява дали сумата 
            //    на първите n числа(лява сума) е равна на сумата на вторите n числа(дясна сума). При равенство печата 
            //    " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.Разликата се изчислява като положително число
            //    (по абсолютна стойност).


            int numbers = int.Parse(Console.ReadLine());
            int counter = 0;
            int leftSum = 0;
            int rightSum = 0;
            int number = 0;
            int sum = 0;

            for (counter = 0; counter < numbers; counter++)
            {
                 number = int.Parse(Console.ReadLine());
                leftSum = number + leftSum;
            }
            for (counter = 0; counter < numbers; counter++)
            {
                number = int.Parse(Console.ReadLine());
                rightSum = number + rightSum;
            }
            if (rightSum == leftSum)
            {
                sum = rightSum;
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)} ");
            }



        }
    }
}
