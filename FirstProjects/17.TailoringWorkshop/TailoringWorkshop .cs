using System;
namespace _17.TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main()
        {
            double tableCount = double.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());

            double lenghtCover = lenghtTable + 0.60;
            double widthCover = widthTable + 0.60;

            double areaCover = lenghtCover * widthCover;

            double squareSide = lenghtTable / 2;
            double squareArea = squareSide * squareSide;


            
            double areaCoveMPrice = areaCover * 7;

            
            double squarAreaMPrice = squareArea * 9;

            double finalPriceD = (areaCoveMPrice + squarAreaMPrice) * tableCount;
            double finalPriceL = finalPriceD * 1.85;

            Console.WriteLine($"{finalPriceD:F2} USD");
            Console.WriteLine($"{finalPriceL:F2} BGN");


            








        }
    }
}