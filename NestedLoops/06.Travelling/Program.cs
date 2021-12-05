using System;
namespace _06.Travelling
{
    class Travelling
    {
        static void Main()
        {
            string destination = Console.ReadLine();          
            double sumCollect = 0;
            double sumCollected = 0;

            while (destination != "End")
            {
              double  vacationBudget = double.Parse(Console.ReadLine());

                while (sumCollected < vacationBudget)
                {
                    sumCollect = double.Parse(Console.ReadLine());
                    sumCollected += sumCollect;

                }

                if (sumCollected >=vacationBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    sumCollected = 0;

                }

                destination = Console.ReadLine();


            }

        }
    }
}