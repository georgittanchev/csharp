using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {

            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string discount = Console.ReadLine();
            int tripDays = int.Parse(Console.ReadLine());
            double price = 0;
            double endValue = 0;
            bool isValid = true;

         

            if (tripDays < 1)
            {
                isValid = false;
                Console.WriteLine("Days must be positive number!");
            }
            else if (!(city == "Bansko" || city == "Borovets" || city == "Varna" || city == "Burgas") || (!(packet == "withEquipment" || packet == "noEquipment" || packet == "withBreakfast" || packet == "noBreakfast")))
            {
                isValid = false;
                Console.WriteLine("Invalid input!");
            }
            else if (city == "Bansko" || city == "Borovets")
            {
                if (packet == "withEquipment")
                {
                    price = tripDays * 100;
                    if (discount == "yes")
                    {
                        price *= 0.9;
                    }
                }
                else if (packet == "noEquipment")
                {
                    price = tripDays * 80;
                    if (discount == "yes")
                    {
                        price *= 0.95;
                    }
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (packet == "withBreakfast")
                {
                    price = tripDays * 130;
                    if (discount == "yes")
                    {
                        price *= 0.88;
                    }
                }
                
                else if (packet == "noBreakfast")
                {
                    price = tripDays * 100;
                    if (discount == "yes")
                    {
                        price *= 0.93;
                    }
                }
            }
            double oneDaysValue = price / tripDays;
            if (tripDays > 7)
            {
                price -= oneDaysValue; 
            }
            if (isValid == true)
            {
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }
        }
    }
}
