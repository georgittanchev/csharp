﻿using System;
namespace _12.ToyShop
{
    class ToyShop
    {
        static void Main()
        {
            double Vacation = double.Parse(Console.ReadLine());
            double Puzzles = double.Parse(Console.ReadLine());
            double TalkingDolls = double.Parse(Console.ReadLine());
            double Minions = double.Parse(Console.ReadLine());
            double Trucks = double.Parse(Console.ReadLine());
        }
    }
}
//12. Магазин за детски играчки
//Петя има магазин за детски играчки.Тя получава голяма поръчка, която трябва да изпълни. С парите, които
//ще спечели иска да отиде на екскурзия. Да се напише програма, която пресмята печалбата от поръчката.
//Цени на играчките:
// Пъзел - 2.60 лв.
// Говореща кукла - 3 лв.
// Плюшено мече - 4.10 лв.
// Миньон - 8.20 лв.
// Камионче - 2 лв.
//Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена.От спечелените
//пари Петя трябва да даде 10% за наема на магазина. Да се пресметне дали парите ще ѝ стигнат да отиде на
//екскурзия.
//Вход
//От конзолата се четат 6 реда:
//1. Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
//2. Брой пъзели - цяло число в интервала [0… 1000]
//3. Брой говорещи кукли - цяло число в интервала [0 … 1000]
//4. Брой плюшени мечета - цяло число в интервала [0 … 1000]
//5. Брой миньони - цяло число в интервала [0 … 1000]
//6. Брой камиончета - цяло число в интервала [0 … 1000]