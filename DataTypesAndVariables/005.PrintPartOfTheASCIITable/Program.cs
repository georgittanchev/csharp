﻿using System;

namespace _005.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {


            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());
            

            for (int i = firstChar; i <= secondChar; i++)
            {
                
                Console.Write(" " + (char)i);

            }




            //Find online more information about ASCII(American Standard Code for Information Interchange) and write a program 
            //    that prints part of the ASCII table of characters at the console.  On the first line of input you will receive the char 
            //    index you should start with and on the second line - the index of the last character you should print.
        }
    }
}
