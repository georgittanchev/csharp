using System;
namespace _15.RadianstoDegrees
{
    class RadianstoDegrees
    {
        static void Main ()
        {
            double radian = double.Parse(Console.ReadLine());
            double degree = radian * 180 / Math.PI;

            Console.WriteLine(Math.Round(degree));

        }
    }
}