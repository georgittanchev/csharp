﻿using System;
namespace _10.CircleAreaandPerimeter
{
    class CircleAreaandPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");


        }
    }
}