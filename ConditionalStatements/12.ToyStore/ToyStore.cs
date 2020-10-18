using System;
namespace _12.ToyStore
{
    class ToyStore
    {
        static void Main()
        {

            double travelPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double finalAmount = puzzles + talkingDolls + teddyBears + minions + trucks;

            double puzzlePrice = puzzles * 2.60;
            double talkingDollsPrice = talkingDolls * 3;
            double teddyBearsPrice = teddyBears * 4.10;
            double minionsPrice = minions * 8.20;
            double trucksPrice = trucks * 2;

            double finalPrice = (puzzlePrice + talkingDollsPrice + teddyBearsPrice + minionsPrice + trucksPrice);

           

             finalPrice = finalPrice * 0.9;

            if (finalAmount >= 50)
            {
                 finalPrice = finalPrice * 0.75;
            }

            if (finalPrice >= travelPrice)
            {
                double leftMoney = finalPrice - travelPrice;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double neededMoney = travelPrice - finalPrice;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }

        }
    }
}