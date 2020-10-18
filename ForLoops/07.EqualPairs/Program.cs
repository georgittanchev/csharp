using System;
namespace _07.EqualPairs
{
    class EqualPairs
    {
        static void Main()
        {
            //Дадени са 2 * n - на брой числа. Първото и второто формират двойка, третото и четвъртото също и т.н.Всяка двойка има стойност – 
            //    сумата от съставящите я числа.Напишете програма, която проверява дали всички двойки имат еднаква стойност или печата
            // максималната 
            //    разлика между две последователни двойки.Ако всички двойки имат еднаква стойност, отпечатайте "Yes, value = {Value}" 
            //    + стойността.В противен случай отпечатайте "No, maxdiff = {Difference}" + максималната разлика.


            int doubleNumber = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int lastSum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 0; i < doubleNumber; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                currentSum = firstNumber + secondNumber;

                if(lastSum !=0)
                {
                    diff = Math.Abs(currentSum - lastSum);
                    if (diff > maxDiff)
                    {
                        
                        maxDiff = diff;
                    }
                }
               

                lastSum = currentSum;

              

            }

            if (currentSum == lastSum && diff == 0)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
         
        }
    }
}