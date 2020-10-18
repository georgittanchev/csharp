using System;
namespace _06.ConcatenateData
{
    class ConcatenateData
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

         
            Console.WriteLine($"You are {name} {family}, a {age}-years old person from {town}.");

        }
    }
}