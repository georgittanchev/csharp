﻿using System;

namespace PointonRectangleBorder
{
    class PointonRectangleBorder
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

           //x1 < x2 && y1 < y2
//            x съвпада с x1 или x2 и същевременно y е между y1 и y2
// y съвпада с y1 или y2 и същевременно x е между x1 и x2

         
            if ((x == x1 || x == x2) && (y>=y1 && y<=y2))
            {
                Console.WriteLine("Border");
            }
            else if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
