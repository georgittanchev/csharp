using System;
using System.Linq;

namespace _8._CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();          
            int i = 0;

            while (array.Length > 1)
            {
                int[] condensed = new int[array.Length - 1];
                for (i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = array[i] + array[i + 1];
                }
                
                array = condensed;

            }
            Console.WriteLine(array[0]);

         
            




 //           Write a program to read an array of integers and condense them by summing adjacent couples of elements
 //               until a single integer is obtained.For example, if we have 3 elements { 2, 10, 3}, we sum the first
 //               two and the second two elements and obtain { 2 + 10, 10 + 3} = { 12, 13},
 //then we sum again all adjacent elements and obtain { 12 + 13} = { 25}.
        }
    }
}
