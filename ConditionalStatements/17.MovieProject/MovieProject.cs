using System;
namespace _17.MovieProject
{
    class MovieProject
    {
        static void Main()
        {
            /*Снимките за дългоочаквания филм &quot;Годзила срещу Конг&quot; започват. Сценаристът Адам Уингард ви моли да
напишете програма, която да изчисли, дали предвидените средства са достатъчни за снимането на филма.
За снимките ще бъдат нужни определен брой статисти, облекло за всеки един статист и декор.
Известно е, че:
 Декорът за филма е на стойност 10% от бюджета.
 При повече от 150 статиста, има отстъпка за облеклото на стойност 10%.
Ред 1. Бюджет за филма – реално число в интервала [1.00 … 1000000.00]
Ред 2. Брой на статистите – цяло число в интервала [1 … 500]
Ред 3. Цена за облекло на един статист – реално число в интервала [1.00 … 1000.00]*/

            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double priceOutfit = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (extras > 150)
            {
                priceOutfit *= 0.9;
            }

            double finalAmount = decor + (priceOutfit * extras);
            double finalFinalAmount = Math.Abs(budget - finalAmount);

            if (finalAmount <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {finalFinalAmount:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalFinalAmount:F2} leva more.");
            }
        }
    }
}
