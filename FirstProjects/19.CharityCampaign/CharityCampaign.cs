using System;
namespace _19.CharityCampaign
{
    class CharityCampaign
    {
        static void Main()
        {
            int campanyDays = int.Parse(Console.ReadLine());
            int bakersCount = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double finalCakePrice = (cakes * bakersCount) * campanyDays * 45;
            double finalWaffleePrice = (waffles * bakersCount) * campanyDays * 5.80;
            double finalPancakesPrice = (pancakes * bakersCount) * campanyDays * 3.20 ;

            double finalPrice = finalCakePrice + finalWaffleePrice + finalPancakesPrice;
            double finalPriceCut = finalPrice / 8;
            double finalPriceFinal = finalPrice - finalPriceCut;

            Console.WriteLine($"{finalPriceFinal:F2}");



        }
    }
}