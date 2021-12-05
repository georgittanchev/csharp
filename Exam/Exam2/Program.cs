using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            double percentAddinationalValue = int.Parse(Console.ReadLine());
            double discount = 0;

            percentAddinationalValue = (percentAddinationalValue / 100) * budget;


            if (nights > 7)
            {
                discount = nightPrice * 0.05;
            }

            double nightsValue = (nightPrice - discount) * nights;

            double endValue = nightsValue + percentAddinationalValue;

            if (endValue > budget)
            {
                Console.WriteLine($"{(endValue - budget):f2} leva needed.");
            }
            else
            {
                Console.WriteLine($"Ivanovi will be left with {(budget-endValue):f2} leva after vacation.");
            }

        }
    }
}
