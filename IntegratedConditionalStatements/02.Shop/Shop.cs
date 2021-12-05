using System;

namespace _02.Shop
{
    class Shop
    {
        static void Main(string[] args)
        {
            //            Напишете програма, която чете продукт(низ), град(низ) и количество(десетично число), въведени от
            //потребителя, и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения
            //град.

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    qantity *= 0.50;
                }
                else if ( product == "water")
                {
                    qantity *= 0.80;
                }
                else if ( product == "beer")
                {
                    qantity *= 1.20;
                }
                else if (product == "sweets")
                {
                    qantity *= 1.45;
                }
                else if (product == "peanuts")
                {
                    qantity *= 1.60;
                }
                Console.WriteLine($"{qantity}");
            }
            if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    qantity *= 0.40;
                }
                else if (product == "water")
                {
                    qantity *= 0.70;
                }
                else if (product == "beer")
                {
                    qantity *= 1.15;
                }
                else if (product == "sweets")
                {
                    qantity *= 1.30;
                }
                else if (product == "peanuts")
                {
                    qantity *= 1.50;
                }
                Console.WriteLine($"{qantity}");
            }
            if (city == "Varna")
            {
                if (product == "coffee")
                {
                    qantity *= 0.45;
                }
                else if (product == "water")
                {
                    qantity *= 0.70;
                }
                else if (product == "beer")
                {
                    qantity *= 1.10;
                }
                else if (product == "sweets")
                {
                    qantity *= 1.35;
                }
                else if (product == "peanuts")
                {
                   qantity *= 1.55;
                }
                Console.WriteLine($"{qantity}");
            }

        }
    }
}
