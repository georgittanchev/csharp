using System;

namespace _16.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Производителите на вендинг машини искали да направят машините си да връщат възможно най - малко монети ресто. 
            //    Напишете програма, която приема сума
            //    -рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.

            decimal amount = decimal.Parse(Console.ReadLine());
            amount *= 100;
            int coinCount = 0;

            // Чейнджа винаги трябва да е в децимал за абсолютна стойност. *//
            

            while (amount > 0)
            {
                if (amount > 200)
                {
                    amount -= 200;
                    coinCount++;
                }
                else if (amount >= 100)
                {
                    amount -= 100;
                    coinCount++;
                }
                else if (amount >= 50)
                {
                    amount -= 50;
                    coinCount++;
                }
                else if (amount >= 20)
                {
                    amount -= 20;
                    coinCount++;
                }
                else if (amount >= 10)
                {
                    amount -= 10;
                    coinCount++;
                }
                else if (amount >= 5)
                {
                    amount -= 5;
                    coinCount++;
                }
                else if (amount >= 2)
                {
                    amount -= 2;
                    coinCount++;
                }
                else if (amount >= 1)
                {
                    amount -= 1;
                    coinCount++;
                }
            }
            Console.WriteLine($"{coinCount}");
        }

    }
}
