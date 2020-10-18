using System;
namespace _13.Birthday
{
    class Birthday
    {
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double litres = lenght * width * height * 0.001;

            double finalPercent = percent / 100;

            double finalLitres = litres * (1-finalPercent);

            Console.WriteLine($"{finalLitres:F3}");


        }
    }
}
