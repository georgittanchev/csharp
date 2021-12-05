using System;
namespace _20.AlcoholMarket1
{
    class AlcoholMarket1
    {
        static void Main()
        {
            
       
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerAmountL = double.Parse(Console.ReadLine());
            double wineAmountL = double.Parse(Console.ReadLine());
            double rakiqAmountL = double.Parse(Console.ReadLine());
            double whiskeyAmountL = double.Parse(Console.ReadLine());

            double rakiqPrice = whiskeyPrice * 0.5;
            double winePrice = rakiqPrice * 0.6;
            double beerPrice = rakiqPrice * 0.2;

            double finalPriceRakiq = rakiqPrice * rakiqAmountL;
            double finalPriceWine = winePrice * wineAmountL;
            double finalPriceBeer = beerPrice * beerAmountL;
            double finalPriceWhiskey = whiskeyPrice * whiskeyAmountL;

            double final = finalPriceRakiq + finalPriceWine + finalPriceBeer + finalPriceWhiskey;
            Console.WriteLine($"{final:F2}");
        }
    }
}
