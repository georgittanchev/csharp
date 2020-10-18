using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int shiftedNumber = 0;
            int number = 0;
            StringBuilder rome = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                number = input[i];
                shiftedNumber = input[i] + 3;
                char character = (char)shiftedNumber;
                rome.Append(character);
            }

            string shiffer = rome.ToString();
            Console.WriteLine(shiffer);

            //Write a program that returns an encrypted version of the same text. Encrypt the text by shifting each character with
            //    three positions forward.For example A would be replaced by 
            //    D, B would become E, and so on.Print the encrypted text.
        }
    }
}
