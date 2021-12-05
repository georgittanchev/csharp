using System;
namespace _12.YardGreening
{
    class YardGreening
    {
        static void Main()
        {
            double squareMetres = double.Parse(Console.ReadLine());

            double squareMeter = squareMetres * 7.61;
            double percent = squareMeter / 100;
            double discount = percent * 18;
            double finalPrice = squareMeter - discount;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
