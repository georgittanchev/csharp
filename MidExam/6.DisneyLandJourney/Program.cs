using System;
using System.Linq;
using System.Collections.Generic;

namespace _6.DisneyLandJourney
{
    class DisneyLandJourney
    {
        static void Main()
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double savings = 0;
            for (int i = 1; i < months+1; i++)
            {
                if (i % 2 != 0 && i != 1)
                {
                    savings -= savings * 0.16;
                }
                if (i % 4 == 0)
                {
                    savings += savings * 0.25;
                }
                savings += journeyCost * 0.25;
            }
            if (journeyCost > savings)
            {
                double difference = journeyCost - savings;
                Console.WriteLine($"Sorry. You need {difference:F2}lv. more.");
            }
            if (savings > journeyCost)
            {
                double difference = savings - journeyCost;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {difference:F2}lv. for souvenirs.");
            }




        }
    }
}