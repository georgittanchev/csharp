using System;

namespace _09.OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bookCounter = int.Parse(Console.ReadLine());
            int counter = 0;
            string book = string.Empty;

            while (counter < bookCounter && book != input)
            {
                book = Console.ReadLine();
                if (input == book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");

                }
                

                counter++;
              
            }
            if (counter == bookCounter && input != book)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }







        }
    }
}
