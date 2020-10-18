using System;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int passangers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            int passangersGettingIn = 0;
            int passangersGettingOut = 0;
            int finalPassangers = 0;

            for (int i = 1; i <= stops; i++)
            {

                passangersGettingOut = int.Parse(Console.ReadLine());
                passangersGettingIn = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    passangersGettingOut += 2;
                    passangers -= passangersGettingOut;
                    passangers += passangersGettingIn;
                }

                else
                {
                    passangersGettingIn += 2;
                    passangers += (passangersGettingIn - passangersGettingOut);
                }

            }


            Console.WriteLine($"The final number of passengers is : {passangers}");
        }
    }
}
