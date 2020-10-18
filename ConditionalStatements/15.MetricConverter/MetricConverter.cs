using System;
namespace _15.MetricConverter
{
    class MetricConverter
    {
        static void Main()
        {
            /*Да се напише програма, която преобразува разстояние между следните 3 мерни единици: mm, cm, m.
Използвайте съответствията от таблицата по-долу:

входна единица изходна единица
1 meter (m) 1000 millimeters (mm)
1 meter (m) 100 centimeters (cm)
Входните данни се състоят от три реда, въведени от потребителя:
 Първи ред: число за преобразуване - реално число
 Втори ред: входна мерна единица - текст
 Трети ред: изходна мерна единица (за резултата) - текст
На конзолата да се отпечата резултатът от преобразуването на мерните единици форматиран до третия знак
след десетичната запетая.*/

            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm")
            {
                number /= 1000;
            }
            else if (input == "cm")
            {
                number /= 100;
            }

            if (output == "mm")
            {
                number *= 1000;
            }
            else if (output == "cm")
            {
                number *= 100;
            }
            Console.WriteLine($"{number:F3}");
        }
    }
}