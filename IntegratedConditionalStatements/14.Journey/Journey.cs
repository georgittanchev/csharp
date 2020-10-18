using System;

namespace _14.Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string vacationType = "";
            string vacationPlace = "";

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    budget *= 0.3;
                    vacationType = "Camp";
                    vacationPlace = "Bulgaria";
                }
                else if (season == "winter")
                {
                    budget *= 0.7;
                    vacationType = "Hotel";
                    vacationPlace = "Bulgaria";
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    budget *= 0.4;
                    vacationType = "Camp";
                    vacationPlace = "Balkans";
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    vacationPlace = "Balkans";
                    budget *= 0.8;
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer" || season == "winter")
                {
                    vacationType = "Hotel";
                    vacationPlace = "Europe";
                    budget *= 0.9;
                }  
            }
            Console.WriteLine($"Somewhere in {vacationPlace}");
            Console.WriteLine($"{vacationType} - {budget:F2}");
         
        }

    }
}
