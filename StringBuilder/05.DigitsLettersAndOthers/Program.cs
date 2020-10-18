using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _05.DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();

            foreach (var item in text)
            {
                if (char.IsDigit(item))
                {
                    sb1.Append(item);
                }
                if (char.IsLetter(item))
                {
                    sb2.Append(item);
                }
                if (char.IsSymbol(item))
                {
                    sb3.Append(item);
                }
                if (char.IsSeparator(item))
                {
                    sb3.Append(item);
                }
                if (char.IsPunctuation(item) || char.IsSurrogate(item))
                {
                    sb3.Append(item);
                }
             
            }

            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            Console.WriteLine(sb3);

        }
    }
}
