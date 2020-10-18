using System;
using System.Linq;

namespace _07.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rightSum = 0;
            int leftSum = 0;
            bool equals = false;


            for (int i = 0; i < array.Length; i++)
            {

                for (int k = i+1; k < array.Length; k++)
                {

                    rightSum += array[k];

                }

                for (int j = 0; j < i; j++)
                {

                    leftSum += array[j];

                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    equals = true;
                    break;
                }

                else
                {
                    rightSum = 0;
                    leftSum = 0;
                }
                
            }


            if (array.Length == 0)
            {
                Console.WriteLine(rightSum);
            }

           else if (equals == false)
            {
                Console.WriteLine("no");
            }
          

        
          

            //Write a program that determines if there exists an element in the array such that the sum of the elements on its left 
            //    is equal to the sum of the elements on its right(there will never be more than 1 element like that). If there are 
            //    no elements to the left / right, their sum is considered to be 0.
            //    Print the index that satisfies the required condition or "no" if there is no such index.
        }
    }
}
