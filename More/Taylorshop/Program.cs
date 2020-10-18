using System;

namespace TaylorShop
{
    class TaylorShop
    {
        static void Main()
        {

            double tableNumbers = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double size = ((lenght + 0.60) * (width + 0.60)) * tableNumbers;
            double kare = ((lenght / 2) * (lenght / 2)) * tableNumbers;

            double tableClothprice = size * 7;
            double karePrice = kare * 9;

            double dollarPrice = tableClothprice + karePrice;
            double levaPrice = dollarPrice * 1.85;

            Console.WriteLine($"{dollarPrice:F2} USD");
            Console.WriteLine($"{levaPrice:F2} BGN");

        }
    }
}

