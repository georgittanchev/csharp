using System;

namespace textAndNumbers
{
    class Textandnumbers
    {
        static void Main()
        {

            string name = Console.ReadLine();
            string familyname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
 


            Console.WriteLine($"You are {name} {familyname}, a {age}-years old person from {city}.");
        }
    }
}