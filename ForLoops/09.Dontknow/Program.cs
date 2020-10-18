using System;

namespace _09.Dontknow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            double numbers = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 0; i < numbersCount; i++)
            {

                numbers = double.Parse(Console.ReadLine());


                if (numbers % 2 == 0)
                {
                    p1++;
                }

                if (numbers % 3 == 0)
                {
                    p2++;
                }

                if (numbers % 4 == 0)
                {
                    p3++;
                }


            }

            p1 = p1 / numbersCount * 100;
            p2 = p2 / numbersCount * 100;
            p3 = p3 / numbersCount * 100;


            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
