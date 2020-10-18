using System;
namespace _03.AccBalance
{
    class AccBalance
    {
        static void Main()
        {
            //            Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой
            //вноски.На първия ред ще получите колко вноски трябва да се направят.На всеки следващ ред ще
            //получавате сумата, която трябва да внесете в сметката, докато не се достигне броя вноски.При всяка
            //получена сума на конзолата трябва да се извежда &quot; Increase: &quot; +сумата и тя да се прибавя в сметката.


            //Ако получите число по-малко от 0 на конзолата трябва да се изведе &quot; Invalid operation!&quot; и програмата
            //да приключи. Когато програмата приключи трябва да се принтира & quot; Total: &quot; +общата сума в сметката
            // закръглена до втория знак след десетичната запетая.

            int deposits = int.Parse(Console.ReadLine());
            int depositsCounter = 0;
            double moneyCounter = 0;

            while (deposits > depositsCounter)
            {
                double money = double.Parse(Console.ReadLine());

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                
                Console.WriteLine($"Increase: {money:F2}");
                moneyCounter = moneyCounter + money;
                depositsCounter++;


            }

           
            Console.WriteLine($"Total: {moneyCounter:F2}");


        }
    }
}
