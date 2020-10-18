using System;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Сумата предвидена за гост изпълнителя - цяло число в интервала[1… 4500]
            //•	На всеки следващ ред(до получаване на команда "The restaurant is full") -броят на хората във всяка група.


            double singerPrice = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double groupPrice = 0;
            int people = 0;
            double finalPrice = 0;
            int finalGuests = 0;

            while (!(command == "The restaurant is full"))
            {
                people = int.Parse(command);
                command = Console.ReadLine();

                if (!(people < 5))
                {
                    groupPrice = people * 70;
                    finalPrice += groupPrice;
                    finalGuests += people;
                }
                else
                {
                    groupPrice = people * 100;
                    finalPrice += groupPrice;
                    finalGuests += people;
                }

            }

            double difference = Math.Abs(finalPrice - singerPrice);

            if (finalPrice >= singerPrice)
            {
                Console.WriteLine($"You have {finalGuests} guests and {difference} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {finalGuests} guests and {finalPrice} leva income, but no singer.");
            }


        }
    }
}
