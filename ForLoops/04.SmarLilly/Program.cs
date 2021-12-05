using System;

namespace _04.SmarLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Лили вече е на N години. За всеки свой рожден ден тя получава подарък. За нечетните рождени дни(1, 3,
            //5...n) получава играчки, а за всеки четен(2, 4, 6...n) получава пари. За втория рожден ден получава 10.00 лв,
            //като сумата се увеличава с 10.00 лв, за всеки следващ четен рожден ден(2 - &gt; 10, 4 - &gt; 20, 6 - &gt; 30...и т.н.). През
            //  годините Лили тайно е спестявала парите.Братът на Лили, в годините, които тя получава пари, взима по 1.00
            //лев от тях.Лили продала играчките получени през годините, всяка за P лева и добавила сумата към
            //спестените пари.С парите искала да си купи пералня за X лева. Напишете програма, която да пресмята,
            //колко пари е събрала и дали ѝ стигат да си купи пералня.

            //            Програмата прочита 3 числа, въведени от потребителя, на отделни редове:
            // Възрастта на Лили - цяло число в интервала[1...77]
            // Цената на пералнята - число в интервала[1.00...10 000.00]
            // Единична цена на играчка -цяло число в интервала[0...40]

            int lilysAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int oddBirthdays = 0;
            int evenBirthDays = 0;
            int evenBirthDaysMoney = 0;
            double saveMoney = 0;
            int toys = 0;
            double diff = 0;
         

            int counter = 1;

            for (counter = 1; counter <= lilysAge; counter++)
            {
                if (counter % 2 == 0)
                {
                    evenBirthDays++;
                    evenBirthDaysMoney += 10;
                    saveMoney += evenBirthDaysMoney;
                  
                }
                else
                {
                    oddBirthdays++;
                    toys++;
                }
                
            }

            toys *= toyPrice;
            saveMoney += toys;
            saveMoney -= evenBirthDays;

            if (saveMoney >= washingMachinePrice)
            {
                saveMoney -= washingMachinePrice;
                Console.WriteLine($"Yes! {saveMoney:f2}");
            }
            else
            {
                diff = Math.Abs(saveMoney - washingMachinePrice);
                Console.WriteLine($"No! {diff:f2}");
            }

        }
    }
}
