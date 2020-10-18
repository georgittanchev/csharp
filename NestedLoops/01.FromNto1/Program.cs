using System;

namespace _01.FromNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            while (!(number == 0 ))
            {
                Console.WriteLine(number);

                number--;
            }
        }
    }
}
