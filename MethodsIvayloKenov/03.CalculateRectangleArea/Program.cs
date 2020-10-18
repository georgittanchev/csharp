using System;

namespace _03.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            CalculatesTheAreaOfTheRectangule(width, height);
        }

        static int CalculatesTheAreaOfTheRectangule(int width, int height)
        {
            int result = width * height;
            Console.WriteLine(result);
            return result;
        }


    }
}
