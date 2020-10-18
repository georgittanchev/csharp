using System;
namespace _16.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Abs(x1 - x2);
            double lenght = Math.Abs(y1 - y2);

            double area = width * lenght;
            double perimeter = 2 * (width + lenght);

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");

        }

    }
}