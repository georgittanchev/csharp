using System;

namespace _10.MovieTheatre
{
    class MovieTheatre
    {
        static void Main(string[] args)
        {
            //            В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.Има три вида прожекции
            //с билети на различни цени:
            // Premiere – премиерна прожекция, на цена 12.00 лева.
            // Normal – стандартна прожекция, на цена 7.50 лева.
            // Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            //Напишете програма, която чете тип прожекция(стринг), брой редове и брой колони в залата(цели числа),
            //въведени от потребителя, и изчислява общите приходи от билети при пълна зала.Резултатът да се отпечата
            //във формат като в примерите по-долу, с 2 знака след десетичната точка.

            string movieType = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;

            if (movieType == "Premiere")
            {
                price = 12;
                totalPrice = (lines * columns) * price;
                Console.WriteLine($"{totalPrice:F2} leva");
            }
           else if (movieType == "Normal")
            {
                price = 7.50;
                totalPrice = (lines * columns) * price;
                Console.WriteLine($"{totalPrice:F2} leva");
            }
          else  if (movieType == "Discount")
            {
                price = 5;
                totalPrice = (lines * columns) * price;
                Console.WriteLine($"{totalPrice:F2} leva");
            }
            

        }
    }
}
