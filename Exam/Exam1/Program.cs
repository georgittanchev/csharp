using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {

            int nailons = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hoursOfWork = int.Parse(Console.ReadLine());

            double addinationalPaint = paint * 0.1;

            double cost = ((nailons + 2) * 1.50) + ((paint + addinationalPaint) * 14.50) + (razreditel * 5) + 0.40;
            double maistori = cost * 0.3;

            double totalValue = cost + (maistori * hoursOfWork);

            Console.WriteLine($"Total expenses: {totalValue:f2} lv.");

        }
    }
}
