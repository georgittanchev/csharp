using System;
namespace _08.InchestoCentimeters
{
    class InchestoCentimeters
    {
        static void Main()
        {
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;

            Console.WriteLine($"{cm:f2}");
        }
    }
}
