using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {


            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());


            double volume = lenght * width * height;
            double litres = volume * 0.001;
            double realPercentage = percentage / 100;

            double usedVolume = (litres * realPercentage);
            double realVolume = litres - usedVolume;

            Console.WriteLine($"{realVolume:F3}");

        }
    }
}
