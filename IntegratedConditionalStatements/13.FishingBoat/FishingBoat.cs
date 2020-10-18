using System;

namespace _13.FishingBoat
{
    class FishingBoat
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            
            double totalPrice = 0;

            if (season == "Spring")
            {
                totalPrice = 3000;
                if (fishermanCount <= 6)
                {
                    totalPrice *= 0.9;
                }
                else if (fishermanCount >7 && fishermanCount <= 11)
                {
                    totalPrice *= 0.85;
                }
                else if (fishermanCount > 12)
                {
                    totalPrice *= 0.75;
                   
                }
                if (fishermanCount % 2 == 0)
                {
                    totalPrice *= 0.95;
                }
            }
            if (season == "Summer" || season == "Autumn")
            {
                totalPrice = 4200;
                if (fishermanCount <= 6)
                {
                    totalPrice *= 0.9;
                }
                else if (fishermanCount > 7 && fishermanCount <= 11)
                {
                    totalPrice *= 0.85;
                }
                else if (fishermanCount > 12)
                {
                    totalPrice *= 0.75;

                }
                if (fishermanCount % 2 == 0 && (!(season == "Autumn")))
                {
                    totalPrice *= 0.95;
                }
            }
            if (season == "Winter")
            {
                totalPrice = 2600;
                if (fishermanCount <= 6)
                {
                    totalPrice *= 0.9;
                }
                else if (fishermanCount > 7 && fishermanCount <= 11)
                {
                    totalPrice *= 0.85;
                }
                else if (fishermanCount > 12)
                {
                    totalPrice *= 0.75;

                }
                if (fishermanCount % 2 == 0)
                {
                    totalPrice *= 0.95;
                }
            }

            if (budget >= totalPrice)
            {
                budget -= totalPrice;
                Console.WriteLine($"Yes! You have {budget:F2} leva left.");
            }
            else if (totalPrice > budget)
            {
                totalPrice -= budget;
                Console.WriteLine($"Not enough money! You need {totalPrice:F2} leva.");
            }



        }
    }
}
