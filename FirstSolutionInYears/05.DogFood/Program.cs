using System;

namespace DogFood
{
    class DogFood
    {
        static void Main()
        {

            int dogs = int.Parse(Console.ReadLine());
            int otherDog = int.Parse(Console.ReadLine());

            double expenses = (dogs * 2.50) + (otherDog * 4);

            Console.WriteLine($"{expenses:F2} lv.");
        }
    }
}