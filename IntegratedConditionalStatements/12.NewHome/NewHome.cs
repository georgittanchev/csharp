using System;

namespace _12.NewHome
{
    class NewHome
    {
        static void Main(string[] args)
        {
            //            Съществуват следните отстъпки:
            // Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            // Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена
            // Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            // Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            // Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double discount = 0;
            double totalPrice = 0;


            if (flowerType == "Roses")
            {
                totalPrice = flowerCount * 5;
                if (flowerCount > 80)
                {
                    discount = totalPrice * 0.1;
                    totalPrice -= discount;

                }
            }
            else if (flowerType == "Dahlias")
            {
                totalPrice = flowerCount * 3.80;
                if (flowerCount > 90)
                {
                    discount = totalPrice * 0.15;
                    totalPrice -= discount;
                }
            }
            else if (flowerType == "Tulips")
            {
                totalPrice = flowerCount * 2.80;
                if (flowerCount > 80)
                {
                    discount = totalPrice * 0.15;
                    totalPrice -= discount;
                }
            }
            else if (flowerType == "Narcissus")
            {
                totalPrice = flowerCount * 3;
                if (flowerCount < 120)
                {
                    discount = totalPrice * 0.15;
                    totalPrice += discount;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                totalPrice = flowerCount * 2.50;
                if (flowerCount < 80)
                {
                    discount = totalPrice * 0.2;
                    totalPrice += discount;
                }
            }
        if (budget >= totalPrice)
            {
              budget -= totalPrice;
              Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget:F2} leva left.");
            }
        else if (budget < totalPrice)
            {
               totalPrice -= budget;
               Console.WriteLine($"Not enough money, you need {totalPrice:F2} leva more.");
            }

            }
        }
    }
