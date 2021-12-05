using System;
namespace _16.HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if ((month == "May" || month == "October"))
            {

                 if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {((nights * 65) * 0.90):F2} lv.");
                    Console.WriteLine($"Studio: {((nights * 50) * 0.70):F2} lv.");
                }

                else if (nights > 7 && nights <= 14)
                {
                    Console.WriteLine($"Apartment: {(nights * 65):F2} lv.");
                    Console.WriteLine($"Studio: {((nights * 50) * 0.95):F2} lv.");
                }

                else
                {
                    Console.WriteLine($"Apartment: {(nights * 65):F2} lv.");
                    Console.WriteLine($"Studio: {(nights * 50):F2} lv.");
                }
               
            }
            if ((month == "June" || month == "September"))
            {

                if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {((nights * 68.70) * 0.90):F2} lv.");
                    Console.WriteLine($"Studio: {((nights * 75.20) * 0.80):F2} lv.");
                }
                else
                {
                Console.WriteLine($"Apartment: {(nights * 68.70):F2} lv.");
                Console.WriteLine($"Studio: {(nights * 75.20):F2} lv.");
                }
            }
            if ((month == "July" || month == "August"))
            {

                if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {((nights * 77) * 0.90):F2} lv.");
                    Console.WriteLine($"Studio: {(nights * 76):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {(nights * 77):F2} lv.");
                    Console.WriteLine($"Studio: {(nights * 76):F2} lv.");
                }
 

            }


        }
    }
}