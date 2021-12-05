using System;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {

            double clubDesire = double.Parse(Console.ReadLine());
            int coctailLength = 0;
            double totalPrice = 0;
            string coctailName = Console.ReadLine();

            while (coctailName != "Party!")
            {
              
                int coctailNumber = int.Parse(Console.ReadLine());

                coctailLength = coctailName.Length;

                double coctailPrice = coctailLength * coctailNumber;

                if (coctailPrice % 2 != 0)
                {
                    coctailPrice *= 0.75;
                }

                 totalPrice += coctailPrice;


                if (totalPrice >= clubDesire)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }


                coctailName = Console.ReadLine();
  
            }

            if (coctailName == "Party!")
            {
                Console.WriteLine($"We need {(clubDesire - totalPrice):f2} leva more.");
                
            }
            Console.WriteLine($"Club income - {totalPrice:f2} leva.");
        }
    }
}
