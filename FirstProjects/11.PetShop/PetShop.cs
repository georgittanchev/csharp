using System;
namespace _11.PetShop
{
    class PetShop
    {
        static void Main()
        {
            double dogs = double.Parse(Console.ReadLine());
            double otherAnimals = double.Parse(Console.ReadLine());

            double dogMeal = dogs * 2.50;
            double otherMeal = otherAnimals * 4;

            double endAmmount = dogMeal + otherMeal;

            Console.WriteLine($"{endAmmount:F2} lv.");
        }
    }
}
