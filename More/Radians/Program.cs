using System;

namespace Radians
{
    class Program
    {
        static void Main(string[] args)
        {

            double radian = double.Parse(Console.ReadLine());
            double angle = (Math.Round(radian * 180 / Math.PI));

            Console.WriteLine($"{angle}");
        }
    }
}
