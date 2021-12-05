using System;

namespace Rectangular
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());


           double lenght = Math.Abs(x2 - x1);
           double width = Math.Abs(y2 - y1);

            double area = lenght * width;
            double peremeter = (lenght + width) * 2;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{peremeter:F2}");

        }
    }
}
