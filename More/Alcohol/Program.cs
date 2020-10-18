using System;

namespace Alcohol
{
    class Program
    {
        static void Main(string[] args)
        {


            double whiskeyPrice = double.Parse(Console.ReadLine());
            double rakiqPrice = whiskeyPrice / 2;
            double winePrice = rakiqPrice * 0.6;
            double beerPrice = rakiqPrice * 0.2;

            double beerCount = double.Parse(Console.ReadLine());
            double wineCount = double.Parse(Console.ReadLine());
            double rakiqCount = double.Parse(Console.ReadLine());
            double whiskeyCount = double.Parse(Console.ReadLine());

            double price = (whiskeyPrice * whiskeyCount) + (rakiqPrice * rakiqCount) + (wineCount * winePrice) + (beerCount * beerPrice);

            Console.WriteLine($"{price:F2}");

        }
    }
}
