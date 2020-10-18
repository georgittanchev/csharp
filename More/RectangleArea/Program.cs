using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double space = x1 + y1;
            double peremeter = x2 * y2;

            Console.WriteLine($"{space:F2}");
            Console.WriteLine($"{peremeter:F2}");




        }
    }
}
