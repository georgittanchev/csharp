using System;

namespace _03.PointInRectangle
{
    class PointInRectangle
    {
        static void Main(string[] args)
        {
            //            Напишете програма, която проверява дали точка { x, y}
            //            се намира вътре в правоъгълник { x1, y1} – { x2, y2}.
            //Входните данни се четат от конзолата и се състоят от 6 реда, въведени от потребителя: десетичните числа x1,
            //y1, x2, y2, x и y(като се гарантира, че x1 < x2 и y1 < y2). Една точка е вътрешна за даден правоъгълник, ако се
            //намира някъде във вътрешността му или върху някоя от страните му.Отпечатайте  Inside  или  Outside .
            //        Подсказка: една точка е вътрешна за даден многоъгълник, ако едновременно са изпълнени следните
            //        четири условия:
            // Точката е надясно от лявата стена на правоъгълника(x >= x1)
            // Точката е наляво от дясната стена на правоъгълника(x <= x2)
            // Точката е надолу от горната стена на правоъгълника(y >= y1)
            // Точката е нагоре от долната стена на правоъгълника(y <= y2)

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x >= x1 && x <=x2 && y >= y1 && y <= y2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }

        }
    }
}
