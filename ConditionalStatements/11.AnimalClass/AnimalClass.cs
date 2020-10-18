using System;
namespace _11.AnimalClass
{
    class AnimalClass
    {
        static void Main()
        {
            string animalClass = Console.ReadLine().ToLower();

            switch (animalClass)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "snake": Console.WriteLine("reptile"); break;
                case "tortoise": Console.WriteLine("reptile"); break;
                case "crocodile": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;


            }
        }
    }
}
