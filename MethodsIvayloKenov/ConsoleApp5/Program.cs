using System;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is the world if not a while = true?");

            //for (int i = 0; i > i-1; i++)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            int days = 0;
            while (true)
            {
                days += 1;
                Console.WriteLine(days);
            }
           
        }
    }
}
