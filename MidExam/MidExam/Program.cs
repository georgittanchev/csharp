using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfASide = double.Parse(Console.ReadLine());
            double numberOfSheets = double.Parse(Console.ReadLine());
            double areaOfASingleSheet = double.Parse(Console.ReadLine());
            double areaOfTheBox = (sizeOfASide * sizeOfASide) * 6;
            double everyThirdCount = Math.Floor(numberOfSheets / 3.0);
            double areaOfEveryThird = areaOfASingleSheet * 0.25;
            double whatICanCover = ((numberOfSheets - everyThirdCount) * areaOfASingleSheet) + (everyThirdCount * areaOfEveryThird);

            double whatsLeft = (whatICanCover / areaOfTheBox) * 100;

            Console.WriteLine($"You can cover {whatsLeft:F2}% of the box.");
        }
    }
}
