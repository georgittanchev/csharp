using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split().ToArray();
            int counter = 0;
            foreach (var word in words)
            {
                counter = word.Length;
                for (int i = 0; i < counter; i++)
                {
                    Console.Write(word);    
                }
            }


        }
    }
}
