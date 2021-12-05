using System;
using System.Linq;

namespace _7._EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool identical = false;
            int i = 0;

            for (i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    identical = true;
                    sum += array1[i];
                    continue;
                }
                else
                {
                    identical = false;
                    break;
                }
            }
            if (identical == false)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {array1[i - 1]} index");
                }
                
              
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
           




            //Read two arrays and print on the console whether they are identical or not. Arrays are identical if 
            //    their elements are equal.If the arrays are identical find the sum of the first one and print on the console following 
            //    message: "Arrays are identical. Sum: {sum}", otherwise find the first index where the arrays differ and print on the console
            //    following message: 
            //"Arrays are not identical. Found difference at {index} index".
        }
    }
}
